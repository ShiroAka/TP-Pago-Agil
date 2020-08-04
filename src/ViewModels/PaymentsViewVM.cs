using PagoAgil.Model;
using System.Collections.Generic;
using System.Linq;

namespace PagoAgil.ViewModels
{
    public class PaymentsViewVM
    {
        public PaymentsViewVM()
        { }

        public IQueryable<FormaDePago> GetPaymentMethods()
        {
            return DatabaseAccess.GetPaymentMethods();
        }

        public void CreateNewPayment(decimal clientId, decimal paymentMethodId, List<Factura> billsToPay)
        {
            PagoDeFacturas payment = new PagoDeFacturas();
            payment.Sucursal = Login.userSubsidiary.idSucursal;
            payment.Cliente = clientId;
            //payment.Fecha = DateTime.Now;
            payment.Fecha = Login.SystemDate;
            payment.MetodoPago = paymentMethodId;

            decimal totalValue = 0;

            //Goes through the bills list to generate the payment's total value
            foreach (Factura bill in billsToPay)
            {
                totalValue += bill.Importe;
            }

            payment.Importe = totalValue;

            DatabaseAccess.CreateNewPayment(payment, billsToPay);
        }
    }
}
