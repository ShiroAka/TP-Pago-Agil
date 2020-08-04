using PagoAgil.Model;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class StatisticalListsViewVM
    {
        public StatisticalListsViewVM()
        { }

        public IQueryable<object> GetPercentageOfBillsAccountedByEnterprise(decimal year, decimal startMonth, decimal endMonth)
        {
            return DatabaseAccess.GetPercentageOfBillsAccountedByEnterprise(year, startMonth, endMonth);
        }

        public IQueryable<object> GetEnterprisesWhichSoldTheMost(decimal year, decimal startMonth, decimal endMonth)
        {
            return DatabaseAccess.GetEnterprisesWhichSoldTheMost(year, startMonth, endMonth);
        }

        public IQueryable<object> GetClientsWhichPayedTheMost(decimal year, decimal startMonth, decimal endMonth)
        {
            return DatabaseAccess.GetClientsWhichPayedTheMost(year, startMonth, endMonth);
        }

        public IQueryable<object> GetClientsWithHighestPercentageOfPayedBills(decimal year, decimal startMonth, decimal endMonth)
        {
            return DatabaseAccess.GetClientsWithHighestPercentegeOfPayedBills(year, startMonth, endMonth); 
        }

        public Empresa GetEnterpriseById(decimal enterpriseId)
        {
            return DatabaseAccess.GetEnterprise(enterpriseId);
        }

        public Cliente GetClientById(decimal clientId)
        {
            return DatabaseAccess.GetClient(clientId);
        }
    }
}
