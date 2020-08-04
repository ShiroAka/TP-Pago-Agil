using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.Threading;
using System.Globalization;

namespace PagoAgil.Model
{
    public static class Login
    {
        public static Usuario loggedUser { get; set; }
        public static Rol userRole { get; set; }
        public static Sucursal userSubsidiary { get; set; }
        public static DateTime SystemDate { get; private set; }

        public static Usuario CheckUsername(string username)
        {
            Usuario user = DatabaseAccess.GetUserByUserName(username); 

            return user;
        }

        public static bool CheckPassword(string password, Usuario user)
        {
            byte[] hashedPassword = PasswordHashing(password);

            if (user.Pass.SequenceEqual(hashedPassword))    //It is mandatory to use that method to compare byte arrays. Comparing them with '==' will not work
                return true;
            else
                return false;
        }

        private static byte[] PasswordHashing(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);

            return hash;
        }

        //It is required by the teachers that all DateTime.Now dates are replaced with a date obtained from the app.config file, so that 
        //they may test the app with different dates without having to change the computer's system date

        public static void GetConfigDate()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            string date = ConfigurationManager.AppSettings["SystemDate"];
            SystemDate = DateTime.Parse(date, Thread.CurrentThread.CurrentCulture);
        }
    }
}
