using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class RoleSelectionViewVM
    {
        public RoleSelectionViewVM()
        { }

        public IQueryable<Rol> GetUserRoles(decimal userId)
        {
            return DatabaseAccess.GetUserRoles(userId);
        }

        public Rol GetUserRole(decimal userId, decimal roleId)
        {
            return DatabaseAccess.GetUserRole(userId, roleId);
        }

        public Sucursal GetUserSubsidiary(decimal userId)
        {
            return DatabaseAccess.GetUserSubsidiary(userId);
        }
    }
}
