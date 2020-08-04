using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class FindClientsViewVM
    {
        public FindClientsViewVM()
        { }

        public IQueryable<Cliente> BuildClientSearchQuery(string clientName, string clientLastName, decimal clientIdentification)
        {
            return DatabaseAccess.BuildClientSearchQuery(clientName, clientLastName, clientIdentification);
        }
    }
}
