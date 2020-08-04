using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class FindBillsViewVM
    {
        public FindBillsViewVM()
        { }

        public IQueryable<Empresa> GetEnterprises()
        {
            return DatabaseAccess.GetActiveEnterprises();
        }

        public IQueryable<Factura> GetClientBills(decimal clientId)
        {
            return DatabaseAccess.GetClientBills(clientId);
        }

        public IQueryable<Factura> BuildFindBillsViewSearchQuery(decimal billNbr, decimal entepriseId, decimal clientId, bool shouldBillBePayed)
        {
            return DatabaseAccess.BuildFindBillsViewSearchQuery(billNbr, entepriseId, clientId, shouldBillBePayed );
        }
    }
}
