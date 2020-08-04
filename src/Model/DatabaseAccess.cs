using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Model
{
    public static class DatabaseAccess
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static Usuario GetUserByUserName(string username)
        {
            return db.Usuario.FirstOrDefault(x => x.Activo && (x.UserName == username));
        }

        public static IQueryable<Empresa> GetActiveEnterprises()
        {
            return db.Empresa.Where(x => x.Activa);
        }

        public static Comision GetCommisionPercentage()
        {
            return db.Comision.First(x => x.FechaDeFin == null);
        }

        public static IQueryable<Factura> GetBillsToAccountByEnterprise(decimal enterpriseId)
        {
            /* This sould be the T-SQL query:
             * 
             * SELECT f.IdFactura, f.Cliente, f.Empresa, f.Nro_Factura, f.FechaAlta, f.FechaVenc, f.Importe, f.Pagada, f.Rendida, f.Activa 
             * FROM UNNAMED_GROUP.Factura f JOIN UNNAMED_GROUP.FacturasPago fp ON fp.Factura = f.idFactura JOIN UNNAMED_GROUP.PagoDeFacturas pf ON fp.Pago = pf.idPago
             * WHERE f.Empresa = @enterpriseId AND f.Pagada = 1 AND f.Rendida = 0
             */

            /* This gets all the bills which were payed but not accounted for till now. 
             * I can check if the payment's month and year are the same as the current date's month and year, but that would leave out all those payed bills 
             * that were not accounted for and were not payed in the current month/year */

            return (from f in db.Factura
                    join fp in db.FacturasPago on f.idFactura equals fp.Factura
                    join pf in db.PagoDeFacturas on fp.Pago equals pf.idPago
                    where f.Empresa == enterpriseId && f.Pagada && !f.Rendida
                    select f);
        }

        public static void AddNewInvoiceAccounting(Rendicion accounting, List<Factura> accountedBills)
        {
            db.Rendicion.Add(accounting);
            db.SaveChanges();

            //Add bills to the corresponding table (FacturasRendicion)
            foreach (Factura bill in accountedBills)
            {
                bill.Rendida = true;
                db.Entry(bill).State = EntityState.Modified;

                FacturasRendicion accountingBill = new FacturasRendicion();
                accountingBill.Factura = bill.idFactura;
                accountingBill.Rendicion = accounting.idRendicion;

                db.FacturasRendicion.Add(accountingBill);
            }

            db.SaveChanges();
        }

        public static void DeleteBill(Factura bill)
        {
            db.Factura.Attach(bill);
            db.Entry(bill).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static IQueryable<Factura> BuildBillSearchQuery(decimal billNumber)
        {
            IQueryable<Factura> query = db.Factura.Where(x => (x.Activa));
            query = query.Where(x => !x.Rendida);
            query = query.Where(x => !x.Pagada);
            query = query.Where(x => x.Nro_Factura == billNumber);

            return query;            
        }

        public static IQueryable<Factura> BuildBillSearchQuery(decimal clientId, decimal enterpriseId)
        {
            IQueryable<Factura> query = db.Factura.Where(x => x.Activa);
            query = query.Where(x => !x.Rendida);
            query = query.Where(x => !x.Pagada);
            query = clientId == 0 ? query : query.Where(x => x.Cliente == clientId);    //If no client was selected in the search view, the clientId will be 0
            query = enterpriseId == 0 ? query : query.Where(x => x.Empresa == enterpriseId); //If no enterprise was selected in the search view, the enterpriseId will be 0

            return query;
        }

        public static Cliente GetClient(decimal clientId)
        {
            return db.Cliente.First(x => x.idCliente == clientId);
        }

        public static IQueryable<Item_Factura> GetBillItems(decimal billId)
        {
            return db.Item_Factura.Where(x => x.Factura == billId);
        }

        public static bool BillExistsInDB(decimal billId, decimal enterpriseId)
        {
            return db.Factura.Any(x => (x.Nro_Factura == billId) && (x.Empresa == enterpriseId));
        }

        public static void CreateNewBill(Factura bill, List<Item_Factura> billItems)
        {
            db.Factura.Add(bill);
            db.SaveChanges();

            //Adds all the items from the items list
            foreach (Item_Factura item in billItems)
            {
                item.Factura = bill.idFactura;
                db.Item_Factura.Add(item);
            }

            db.SaveChanges();
        }

        public static void ModifyExistingBill(Factura bill, List<Item_Factura> billItems)
        {
            db.SaveChanges();   //Saves changes to the modified bill object that was obtained from de DB, which was modified in the calling method

            //Delete all bill items (from the corresponding database table) that reference to this bill
            IQueryable<Item_Factura> billItemsList = GetBillItems(bill.idFactura);

            foreach (Item_Factura item in billItemsList)
            {
                db.Item_Factura.Remove(item);
            }

            db.SaveChanges();

            //Add all items from the actual items list
            foreach (Item_Factura item in billItems)
            {
                item.Factura = bill.idFactura;
                db.Item_Factura.Add(item);
            }

            db.SaveChanges();
        }

        public static Factura GetBill(decimal billId)
        {
            return db.Factura.First(x => x.idFactura == billId);
        }

        public static void DeleteBranchOffice(Sucursal branchOffice)
        {
            db.Sucursal.Attach(branchOffice);
            db.Entry(branchOffice).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static IQueryable<Sucursal> BuildBranchOfficeSearchQuery(string branchOfficeName, string branchOfficeAddress, decimal branchOfficeZipCode)
        {
            IQueryable<Sucursal> query = db.Sucursal.Where(x => x.Activa);
            query = branchOfficeName == "" ? query : query.Where(x => x.Nombre == branchOfficeName);
            query = branchOfficeAddress == "" ? query : query.Where(x => x.Direccion == branchOfficeAddress);
            query = branchOfficeZipCode == 0 ? query : query.Where(x => x.Cod_Postal == branchOfficeZipCode);

            return query;
        }

        public static Sucursal GetBranchOffice(decimal branchOfficeId)
        {
            return db.Sucursal.First(x => x.idSucursal == branchOfficeId);
        }

        public static void ModifyExistingBranchOffice()
        {
            db.SaveChanges();
        }

        public static void CreateNewBranchOffice(Sucursal branchOffice)
        {   
            db.Sucursal.Add(branchOffice);
            db.SaveChanges();
        }

        public static void DeleteClient(Cliente client)
        {
            db.Cliente.Attach(client);
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static IQueryable<Cliente> BuildClientSearchQuery(string clientName, string clientLastName, decimal clientIdentification)
        {
            IQueryable<Cliente> query = null;

            query = db.Cliente.Where(x => x.Activo);
            query = clientName == "" ? query : query.Where(x => x.Nombre.Contains(clientName));
            query = clientLastName == "" ? query : query.Where(x => x.Apellido.Contains(clientLastName));
            query = clientIdentification == 0 ? query : query.Where(x => x.DNI == clientIdentification);

            return query;
        }

        public static bool IsMailAlreadyInUse(string mail, decimal clientId)
        {
            return db.Cliente.Any(x => (x.Mail == mail) && (x.idCliente != clientId));
        }

        public static bool IsMailAlreadyInUse(string mail)
        {
            return db.Cliente.Any(x => (x.Mail == mail));
        }

        public static void CreateNewClient(Cliente client)
        {
            db.Cliente.Add(client);
            db.SaveChanges();
        }

        public static void ModifyExistingClient()
        {
            db.SaveChanges();
        }

        public static IQueryable<Rubro> GetAreas()
        {
            return db.Rubro;
        }

        public static IQueryable<string> GetAreaNames()
        {
            return db.Rubro.Select(rubro => rubro.Nombre).Distinct();
        }

        public static void DeleteEnteprise(Empresa enterprise)
        {
            db.Empresa.Attach(enterprise);
            db.Entry(enterprise).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static IQueryable<Empresa> BuildEnterpriseSearchQuery(string enterpriseName, string enterpriseCuit, decimal areaId)
        {
            IQueryable<Empresa> query = null;

            query = db.Empresa.Where(x => x.Activa);
            query = enterpriseName == "" ? query : query.Where(x => x.Nombre.Contains(enterpriseName));
            query = enterpriseCuit == "" ? query : query.Where(x => x.Cuit == enterpriseCuit);
            query = areaId == 0 ? query : query.Where(x => x.Rubro == areaId);

            return query;
        }

        public static Rubro GetEnterpriseArea(decimal enterpriseAreaId)
        {
            return db.Rubro.First(rubro => rubro.idRubro == enterpriseAreaId);
        }

        public static Rubro GetAreaByName(string areaName)
        {
            return db.Rubro.First(rubro => rubro.Nombre == areaName);
        }

        public static void CreateNewEnterprise(Empresa enterprise)
        {
            db.Empresa.Add(enterprise);
            db.SaveChanges();
        }

        public static void ModifyExistingEnterprise()
        {
            db.SaveChanges();
        }

        public static Empresa GetEnterprise(decimal enterpriseId)
        {
            return db.Empresa.First(x => x.idEmpresa == enterpriseId);
        }

        public static IQueryable<FormaDePago> GetPaymentMethods()
        {
            return db.FormaDePago;
        }

        public static void CreateNewPayment(PagoDeFacturas payment, List<Factura> billsToPay)
        {
            db.PagoDeFacturas.Add(payment);
            db.SaveChanges();

            //Goes through the entire bills list (again) to mark each bill as payed, and relate each bill to this payment
            foreach (Factura bill in billsToPay)
            {
                FacturasPago paymentBill = new FacturasPago();
                paymentBill.Pago = payment.idPago;
                paymentBill.Factura = bill.idFactura;

                bill.Pagada = true;
                db.Entry(bill).State = EntityState.Modified;
                db.SaveChanges();

                db.FacturasPago.Add(paymentBill);
                db.SaveChanges();
            }
        }

        public static IQueryable<Rol> GetRoles()
        {
            return db.Rol.Where(x => x.Activo);
        }

        public static Rol GetRoleById(decimal roleId)
        {
            return db.Rol.First(x => x.idRol == roleId);
        }

        public static IQueryable<Funcionalidad> GetRolePermissions(decimal roleId)
        {
            return (from f in db.FuncionalidadesRol
                    join ff in db.Funcionalidad on f.Funcionalidad equals ff.idFuncionalidad
                    where f.Rol == roleId
                    select ff);
        }

        public static void DeleteRole(Rol role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static IQueryable<Funcionalidad> GetPermissions()
        {
            return db.Funcionalidad;
        }

        public static void ModifyExistingRole(Rol role, List<Funcionalidad> permissionsList)
        {
            db.Entry(role).State = EntityState.Modified;
            db.SaveChanges();

            //Delete al role permissions
            IQueryable<FuncionalidadesRol> rolePermissions = db.FuncionalidadesRol.Where(x => x.Rol == role.idRol);

            foreach (FuncionalidadesRol rolePermission in rolePermissions)
            {
                db.FuncionalidadesRol.Remove(rolePermission);
            }
            db.SaveChanges();

            //Add all the roles from the list

            foreach (Funcionalidad permission in permissionsList)
            {
                FuncionalidadesRol rolePermission = new FuncionalidadesRol();
                rolePermission.Funcionalidad = permission.idFuncionalidad;
                rolePermission.Rol = role.idRol;

                db.FuncionalidadesRol.Add(rolePermission);
                db.SaveChanges();
            }
        }

        public static Rol GetRoleByName(string roleName)
        {
            return db.Rol.FirstOrDefault(x => x.Nombre == roleName);
        }

        public static void ReactivateRole(Rol role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void CreateNewRole(Rol role, List<Funcionalidad> permissionsList)
        {
            db.Rol.Add(role);
            db.SaveChanges();

            foreach (Funcionalidad permission in permissionsList)
            {
                FuncionalidadesRol rolePermission = new FuncionalidadesRol();
                rolePermission.Rol = role.idRol;
                rolePermission.Funcionalidad = permission.idFuncionalidad;

                db.FuncionalidadesRol.Add(rolePermission);
            }
            db.SaveChanges();
        }

        public static IQueryable<Factura> GetClientBills(decimal clientId)
        {
            return db.Factura.Where(x => (x.Cliente == clientId) && !x.Pagada && !x.Rendida && x.Activa);
        }

        public static IQueryable<Factura> BuildFindBillsViewSearchQuery(decimal billNbr, decimal entepriseId, decimal clientId, bool shouldBillBePayed)
        {
            IQueryable<Factura> query = null;
            query = db.Factura.Where(x => x.Activa);
            query = query.Where(x => !x.Rendida);
            query = shouldBillBePayed ? query.Where(x => x.Pagada) : query.Where(x => !x.Pagada);
            query = billNbr == 0 ? query : query.Where(x => x.Nro_Factura == billNbr);
            query = entepriseId == 0 ? query : query.Where(x => x.Empresa == entepriseId);
            query = clientId == 0 ? query : query.Where(x => x.Cliente == clientId);

            return query;

        }

        public static IQueryable<object> GetPercentageOfBillsAccountedByEnterprise(decimal year, decimal startMonth, decimal endMonth)
        {
            return (from f in db.Factura
                    where f.FechaAlta.Year == year && f.FechaAlta.Month >= startMonth && f.FechaAlta.Month <= endMonth
                    group f by new { f.Empresa } into g
                    orderby 2 descending
                    select new
                    {
                        EnterpriseId = g.Key.Empresa,
                        Percentage = g.Count(f => f.Pagada == true) * 1.00 / g.Count(f => f.Pagada == true || f.Pagada == false) * 100
                    });
        }

        public static IQueryable<object> GetEnterprisesWhichSoldTheMost(decimal year, decimal startMonth, decimal endMonth)
        {
            var enterprisesTotalAccountedValue = from r in db.Rendicion
                                                 where (r.Fecha).Year == year && r.Fecha.Month >= startMonth && r.Fecha.Month <= endMonth
                                                 group r by new { r.Empresa } into g
                                                 orderby 2 descending
                                                 select new
                                                 {
                                                    EnterpriseId = g.Key.Empresa,
                                                    EnterpriseTotalAcountedValue = g.Sum(f => f.ImporteTotal)
                                                 };

            var maxTotalAccountedValue = enterprisesTotalAccountedValue.Max(x => x.EnterpriseTotalAcountedValue);
            return enterprisesTotalAccountedValue.Where(x => x.EnterpriseTotalAcountedValue == maxTotalAccountedValue);
        }

        public static IQueryable<object> GetClientsWhichPayedTheMost(decimal year, decimal startMonth, decimal endMonth)
        {
            var clientsTotalPayments = from pf in db.PagoDeFacturas
                                       where (pf.Fecha.Year) == year && pf.Fecha.Month >= startMonth && pf.Fecha.Month <= endMonth
                                       group pf by new { pf.Cliente } into g
                                       orderby 2 descending
                                       select new
                                       {
                                           ClientId = g.Key.Cliente,
                                           ClientTotalPayments = g.Sum(f => f.Importe)
                                       };

            var maxTotalPayment = clientsTotalPayments.Max(x => x.ClientTotalPayments);
            return clientsTotalPayments.Where(x => x.ClientTotalPayments == maxTotalPayment);
        }

        public static IQueryable<object> GetClientsWithHighestPercentegeOfPayedBills(decimal year, decimal startMonth, decimal endMonth)
        {
            var clients = from f in db.Factura
                          where f.FechaAlta.Year == year && f.FechaAlta.Month >= startMonth && f.FechaAlta.Month <= endMonth
                          group f by new { f.Cliente } into g
                          orderby 2 descending
                          select new
                          {
                              ClientId = g.Key.Cliente,
                              Percentage = g.Count(f => f.Pagada == true) * 1.00 / g.Count(f => f.Pagada == true || f.Pagada == false) * 100
                          };

            var maximumPercentage = clients.Max(x => x.Percentage);
            return clients.Where(x => x.Percentage == maximumPercentage);
        }

        public static void CreateNewArea(Rubro area)
        {
            db.Rubro.Add(area);
            db.SaveChanges();
        }

        public static void MarkBillAsNotPayed(Factura bill)
        {
            db.Entry(bill).State = EntityState.Modified;    //It is mandatory to save changes for each updated bill; the corresponding trigger can only handle a bill at a time (it has no cursor cause it gave problems with entity)
            db.SaveChanges();
        }

        public static void DeactivateUser(Usuario user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static int CountUserRoles(decimal userId)
        {
            return db.RolesUsuario.Count(x => x.Usuario == userId);
        }

        public static Rol GetUserRole(decimal userId)
        {
            return (from r in db.Rol
                    join ur in db.RolesUsuario on r.idRol equals ur.Rol
                    where ur.Usuario == userId
                    select r).First();
        }

        public static Rol GetUserRole(decimal userId, decimal roleId)
        {
            return (from r in db.Rol
                    join ur in db.RolesUsuario on r.idRol equals ur.Rol
                    where ur.Usuario == userId && r.idRol == roleId
                    select r).First();
        }

        public static Sucursal GetUserSubsidiary(decimal userId)
        {
            return (from s in db.Sucursal
                    join su in db.UsuariosSucursal on s.idSucursal equals su.Sucursal
                    where su.Usuario == userId
                    select s).First();
        }

        public static IQueryable<Rol> GetUserRoles(decimal userId)
        {
            return (from r in db.Rol
                    join ur in db.RolesUsuario on r.idRol equals ur.Rol
                    where ur.Usuario == userId
                    select r);
        }

        public static Funcionalidad GetPermission(decimal permissionId)
        {
            return db.Funcionalidad.First(x => x.idFuncionalidad == permissionId);
        }
    }
}
