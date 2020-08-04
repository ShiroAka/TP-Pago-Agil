using System;
using System.Collections.Generic;
using System.Linq;
using PagoAgil.Model;

namespace PagoAgil.ViewModels
{
    public class InvoiceAccountingVM
    {
        public List<Factura> BillsToAccount { get; set; }
        public decimal CommisionPercentage { get; set; }
        public decimal TotalCommisionValue { get; set; }
        public int BillsToAccountQuantity { get; set; }
        public decimal TotalAccountingValue { get; set; }

        public InvoiceAccountingVM()
        {
            CommisionPercentage = GetCommisionPercentage().PorcentajeComision;
        }

        public IQueryable<Empresa> GetActiveEnterprises()
        {
            return DatabaseAccess.GetActiveEnterprises();
        }

        public Comision GetCommisionPercentage()
        {
            return DatabaseAccess.GetCommisionPercentage();
        }

        public IQueryable<Factura> GetBillsToAccountByEnterprise(decimal enterpriseId)
        {
            return DatabaseAccess.GetBillsToAccountByEnterprise(enterpriseId);
        }

        public decimal CalculateTotalAccountingValue(decimal enterpriseId)
        {
            List<Factura> BillsToAccount = GetBillsToAccountByEnterprise(enterpriseId).ToList();

            BillsToAccountQuantity = BillsToAccount.Count;
            decimal TotalAccountingValue = 0;

            foreach (Factura bill in BillsToAccount)
            {
                TotalAccountingValue += bill.Importe;
            }

            return TotalAccountingValue;
        }

        public decimal CalculateTotalCommisionValue()
        {
            return TotalAccountingValue * (CommisionPercentage / (decimal)100);
        }

        public void AccountInvoices(decimal enterpriseId)
        {
            Rendicion accounting = new Rendicion();

            accounting.Empresa = enterpriseId;
            //accounting.Fecha = DateTime.Now;
            accounting.Fecha = Login.SystemDate;
            accounting.FacturasRendidas = BillsToAccountQuantity;
            accounting.ImporteTotal = TotalAccountingValue - TotalCommisionValue;
            accounting.PorcentajeComision = CommisionPercentage;
            accounting.TotalComision = TotalCommisionValue;

            DatabaseAccess.AddNewInvoiceAccounting(accounting, BillsToAccount);            
        }
    }
}
