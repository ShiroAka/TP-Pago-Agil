using PagoAgil.Model;

namespace PagoAgil.ViewModels
{
    public class BranchesViewVM
    {
        public BranchesViewVM()
        { }

        public void ModifyExistingBranchOffice(decimal branchOfficeId, string branchOfficeName, string branchOfficeAddress, decimal branchOfficeZipCode)
        {
            Sucursal branchOffice = DatabaseAccess.GetBranchOffice(branchOfficeId);

            branchOffice.Nombre = branchOfficeName;
            branchOffice.Direccion = branchOfficeAddress;
            branchOffice.Cod_Postal = branchOfficeZipCode;

            DatabaseAccess.ModifyExistingBranchOffice();
        }

        public void CreateNewBranchOffice(string branchOfficeName, string branchOfficeAddress, decimal branchOfficeZipCode)
        {
            Sucursal branchOffice = new Sucursal();

            branchOffice.Nombre = branchOfficeName;
            branchOffice.Direccion = branchOfficeAddress;
            branchOffice.Cod_Postal = branchOfficeZipCode;
            branchOffice.Activa = true;

            DatabaseAccess.CreateNewBranchOffice(branchOffice);
        }
    }
}
