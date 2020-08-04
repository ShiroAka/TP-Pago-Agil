using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class RolesSearchViewVM
    {
        public RolesSearchViewVM()
        { }

        public IQueryable<Rol> GetRoles()
        {
            return DatabaseAccess.GetRoles();
        }

        public Rol GetRoleById(decimal roleId)
        {
            return DatabaseAccess.GetRoleById(roleId);
        }

        public IQueryable<Funcionalidad> GetRolePermissions(decimal roleId)
        {
            return DatabaseAccess.GetRolePermissions(roleId);
        }

        public void DeleteRole(decimal roleId)
        {
            Rol role = DatabaseAccess.GetRoleById(roleId);
            role.Activo = false;

            DatabaseAccess.DeleteRole(role);
        }
    }
}
