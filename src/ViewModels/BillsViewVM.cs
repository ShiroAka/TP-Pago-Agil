using PagoAgil.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class BillsViewVM
    {
        public BillsViewVM()
        { }

        public Cliente GetClient(decimal clientId)
        {
            return DatabaseAccess.GetClient(clientId);
        }

        public IQueryable<Empresa> GetEnterprises()
        {
            return DatabaseAccess.GetActiveEnterprises();
        }

        public IQueryable<Item_Factura> GetBillItems(decimal billId)
        {
            return DatabaseAccess.GetBillItems(billId);
        }

        public bool BillExistsInDB(decimal billId, decimal enterpriseId)
        {
            return DatabaseAccess.BillExistsInDB(billId, enterpriseId);
        }

        public void CreateNewBill(decimal clientId, decimal enterpriseId, DateTime billCreationDate, DateTime billExpirationDate, decimal billId, decimal totalBillValue, List<Item_Factura> billItems)
        {
            Factura bill = new Factura();
            bill.Cliente = clientId;
            bill.Empresa = enterpriseId;    //Cannot cast to 'decimal' here, so I have to convert that value
            bill.FechaAlta = billCreationDate;
            bill.FechaVenc = billExpirationDate;
            bill.Nro_Factura = billId;
            bill.Importe = totalBillValue;

            DatabaseAccess.CreateNewBill(bill, billItems);
        }

        public void ModifyExistingBill(decimal billId, decimal clientId, decimal enterpriseId, DateTime billCreationDate, DateTime billExpirationdate, decimal totalBillValue, decimal billNumber, List<Item_Factura> billItems)
        {
            Factura bill = GetBillFromDB(billId);

            bill.Cliente = clientId;
            bill.Empresa = enterpriseId;
            bill.FechaAlta = billCreationDate;
            bill.FechaVenc = billExpirationdate;
            bill.Importe = totalBillValue;
            bill.Nro_Factura = billNumber;

            DatabaseAccess.ModifyExistingBill(bill, billItems);
        }

        public Factura GetBillFromDB(decimal billId)
        {
            return DatabaseAccess.GetBill(billId);
        }
    }
}
