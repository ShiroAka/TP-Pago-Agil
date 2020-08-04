using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class BillsSearchViewVM
    {
        public BillsSearchViewVM()
        { }

        public IQueryable<Empresa> GetEnterprises()
        {
            return DatabaseAccess.GetActiveEnterprises();
        }

        public void DeleteBill(Factura bill)
        {
            bill.Activa = false;

            DatabaseAccess.DeleteBill(bill);
        }

        public IQueryable<Factura> BuildSearchQuery(decimal billId)
        {
            return DatabaseAccess.BuildBillSearchQuery(billId);
        }

        public IQueryable<Factura> BuildSearchQuery(decimal clientId, decimal enterpriseId)
        {
            return DatabaseAccess.BuildBillSearchQuery(clientId, enterpriseId);
        }
    }
}
