using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class MainViewVM
    {
        public MainViewVM()
        { }
        
        public IQueryable<Funcionalidad> GetRolePermissions(decimal roleId)
        {
            return DatabaseAccess.GetRolePermissions(roleId);
        }
    }
}
