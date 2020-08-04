using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class BranchesSearchViewVM
    {
        public BranchesSearchViewVM()
        { }

        public void DeleteBranchOffice(Sucursal branchOffice)
        {
            branchOffice.Activa = false;

            DatabaseAccess.DeleteBranchOffice(branchOffice);
        }

        public IQueryable<Sucursal> BuildSearchQuery(string branchOfficeName, string branchOfficeAddress, decimal branchOfficeZipCode)
        {
            return DatabaseAccess.BuildBranchOfficeSearchQuery(branchOfficeName, branchOfficeAddress, branchOfficeZipCode);
        }
    }
}
