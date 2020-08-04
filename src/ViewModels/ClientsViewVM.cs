using PagoAgil.Model;
using System;

namespace PagoAgil.ViewModels
{
    public class ClientsViewVM
    {
        public ClientsViewVM()
        { }

        public bool IsMailAlreadyInUse(string mail, decimal clientId)
        {
            return DatabaseAccess.IsMailAlreadyInUse(mail, clientId);
        }

        public bool IsMailAlreadyInUse(string mail)
        {
            return DatabaseAccess.IsMailAlreadyInUse(mail);
        }

        public void CreateNewClient(string name, string lastName, string mail, string phone, decimal identification, string street, string floor, string apartment, 
                                    string city, string zipCode, DateTime birthDate)
        {
            Cliente client = new Cliente();
            client.Nombre = name;
            client.Apellido = lastName;
            client.Mail = mail;
            client.Telefono = phone;
            client.DNI = identification;
            client.Cod_Postal = zipCode;
            client.Fecha_Nac = birthDate;

            if (apartment == String.Empty)
                client.Direccion = street + "," + floor + "," + city;
            else
                client.Direccion = street + "," + floor + "," + apartment + "," + city;

            DatabaseAccess.CreateNewClient(client);
        }

        public void ModifyExistingClient(decimal clientId, string name, string lastName, string mail, string phone, decimal identification, string street, string floor, string apartment,
                                         string city, string zipCode, DateTime birthDate)
        {
            Cliente client = DatabaseAccess.GetClient(clientId);
            client.Nombre = name;
            client.Apellido = lastName;
            client.Mail = mail;
            client.Telefono = phone;
            client.DNI = identification;
            client.Cod_Postal = zipCode;
            client.Fecha_Nac = birthDate;
            client.DatosErroneos = false;

            if (apartment == String.Empty)
                client.Direccion = street + "," + floor + "," + city;
            else
                client.Direccion = street + "," + floor + "," + apartment + "," + city;

            DatabaseAccess.ModifyExistingClient();
        }
    }
}
