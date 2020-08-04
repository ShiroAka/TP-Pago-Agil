using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.SearchViews;
using PagoAgil.ViewModels;

namespace PagoAgil.BillReturn
{
    public partial class BillReturnView : Form, BillSearchingForm
    {
        private BillReturnViewVM viewModel = new BillReturnViewVM();
        private BindingList<Factura> BillsToReturn { get; set; }
        public Factura CurrentBill { get; set; }

        public BillReturnView()
        {
            InitializeComponent();
            this.CenterToScreen();
            BillsToReturn = new BindingList<Factura>();
            _BillsToReturn.DataSource = BillsToReturn;
            FormatDataGrid();
        }

        #region Events
        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            List<decimal> billIDs = new List<decimal>();
            foreach (Factura bill in BillsToReturn)
            {
                billIDs.Add(bill.idFactura);
            }

            FindBillsView view = new FindBillsView(billIDs.ToArray());

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            if(dialogResult == DialogResult.OK)
                this.BillsToReturn.Add(CurrentBill);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;

            //Mark each bill as not payed
            foreach (Factura bill in BillsToReturn)
            {
                viewModel.MarkBillAsNotPayed(bill);
            }

            //Using an AFTER UPDATE trigger, I will remove the row that references to each bill from the 'FacturasPago' table

            MessageBox.Show(this, "Los pagos han sido devueltos exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private void FormatDataGrid()
        {
            _BillsToReturn.ClearSelection();
            _BillsToReturn.Columns["idFactura"].Visible = false;
            _BillsToReturn.Columns["Empresa"].Visible = false;
            _BillsToReturn.Columns["Cliente"].Visible = false;
            _BillsToReturn.Columns["Pagada"].Visible = false;
            _BillsToReturn.Columns["Rendida"].Visible = false;
            _BillsToReturn.Columns["Activa"].Visible = false;
            _BillsToReturn.Columns["FacturasPago"].Visible = false;
            _BillsToReturn.Columns["FacturasRendicion"].Visible = false;
            _BillsToReturn.Columns["Item_Factura"].Visible = false;
            _BillsToReturn.Columns["Empresa1"].HeaderText = "Empresa";
            _BillsToReturn.Columns["Cliente1"].HeaderText = "Cliente";
            _BillsToReturn.Columns["Empresa1"].DataPropertyName = "Empresa1.Nombre";
            _BillsToReturn.Columns["Cliente1"].DataPropertyName = "Cliente1.Nombre";
        }

        private bool WrongOrEmptyFields()
        {
            if ((BillsToReturn == null) || (BillsToReturn.Count == 0))
            {
                MessageBox.Show(this, "Debe agregar facturas antes de realizar una devolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (this.ReturnReason.Text == String.Empty)
            {
                MessageBox.Show(this, "Debe especificar un motivo para la devolucion de facturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
        #endregion
    }
}
