using PagoAgil.Model;

namespace PagoAgil.ViewModels
{
    public class BillReturnViewVM
    {
        public BillReturnViewVM()
        { }

        public void MarkBillAsNotPayed(Factura bill)
        {
            bill.Pagada = false;
            DatabaseAccess.MarkBillAsNotPayed(bill);
        }
    }
}
