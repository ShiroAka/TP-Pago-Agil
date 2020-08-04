using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class LoginViewVM
    {
        public LoginViewVM()
        { }

        public void DeactivateUser(Usuario user)
        {
            user.Activo = false;
            DatabaseAccess.DeactivateUser(user);
        }

        public int CountUserRoles(decimal userId)
        {
            return DatabaseAccess.CountUserRoles(userId);
        }

        public Rol GetUserRole(decimal userId)
        {
            return DatabaseAccess.GetUserRole(userId);
        }

        public Sucursal GetUserSubsidiary(decimal userId)
        {
            return DatabaseAccess.GetUserSubsidiary(userId);
        }
    }
}
