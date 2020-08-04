using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class ClientsSearchViewVM
    {
        public ClientsSearchViewVM()
        { }

        public void DeleteClient(Cliente client)
        {
            client.Activo = false;

            DatabaseAccess.DeleteClient(client);
        }

        public IQueryable<Cliente> BuildClientSearchQuery(string clientName, string clientLastName, decimal clientIdentification)
        {
            return DatabaseAccess.BuildClientSearchQuery(clientName, clientLastName, clientIdentification);
        }
    }
}
