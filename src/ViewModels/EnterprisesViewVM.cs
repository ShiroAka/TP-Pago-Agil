using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class EnterprisesViewVM
    {
        public EnterprisesViewVM()
        { }

        public IQueryable<string> GetAreaNames()
        {
            return DatabaseAccess.GetAreaNames();
        }

        public Rubro GetEnterpriseArea(decimal enterpriseAreaId)
        {
            return DatabaseAccess.GetEnterpriseArea(enterpriseAreaId);
        }

        public void CreateNewEnterprise(string name, string address, string cuit, string areaName)
        {
            Empresa enterprise = new Empresa();
            enterprise.Nombre = name;
            enterprise.Direccion = address;
            enterprise.Cuit = cuit;
            enterprise.Rubro = DatabaseAccess.GetAreaByName(areaName).idRubro;
            enterprise.Activa = true;

            DatabaseAccess.CreateNewEnterprise(enterprise);
        }

        public void ModifyExistingEnterprise(decimal enterpriseId, string name, string address, string cuit, string areaName)
        {
            Empresa enterprise = DatabaseAccess.GetEnterprise(enterpriseId);
            enterprise.Nombre = name;
            enterprise.Direccion = address;
            enterprise.Cuit = cuit;
            enterprise.Rubro = DatabaseAccess.GetAreaByName(areaName).idRubro;


        }
    }
}
