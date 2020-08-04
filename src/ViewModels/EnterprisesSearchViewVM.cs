using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class EnterprisesSearchViewVM
    {
        public EnterprisesSearchViewVM()
        { }

        public IQueryable<Rubro> GetAreas()
        {
            return DatabaseAccess.GetAreas();
        }

        public void DeleteEnterprise(Empresa enterprise)
        {
            enterprise.Activa = false;
            DatabaseAccess.DeleteEnteprise(enterprise);            
        }

        public IQueryable<Empresa> BuildEnterpriseSearchQuery(string enterpriseName, string enterpriseCuit, decimal areaId)
        {
            return DatabaseAccess.BuildEnterpriseSearchQuery(enterpriseName, enterpriseCuit, areaId);
        }
    }
}
