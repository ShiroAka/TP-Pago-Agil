using PagoAgil.Model;
using System.Collections.Generic;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class RolesViewVM
    {
        public RolesViewVM()
        { }

        public IQueryable<Funcionalidad> GetPermissions()
        {
            return DatabaseAccess.GetPermissions();
        }

        public IQueryable<Funcionalidad> GetRolePermissions(decimal roleId)
        {
            return DatabaseAccess.GetRolePermissions(roleId);
        }

        public void ModifyExistingRole(decimal roleId, string roleName, List<Funcionalidad> permissionsList)
        {
            Rol role = DatabaseAccess.GetRoleById(roleId);

            role.Nombre = roleName;

            DatabaseAccess.ModifyExistingRole(role, permissionsList);
        }

        public Rol GetRoleByName(string roleName)
        {
            return DatabaseAccess.GetRoleByName(roleName);
        }

        public void ReactivateRole(Rol role)
        {
            role.Activo = true;

            DatabaseAccess.ReactivateRole(role);
        }

        public void CreateNewRole(string roleName, List<Funcionalidad> permissionsList)
        {
            Rol role = new Rol();
            role.Nombre = roleName;

            DatabaseAccess.CreateNewRole(role, permissionsList);
        }

        public Funcionalidad GetPermission(decimal permissionId)
        {
            return DatabaseAccess.GetPermission(permissionId);
        }
    }
}
