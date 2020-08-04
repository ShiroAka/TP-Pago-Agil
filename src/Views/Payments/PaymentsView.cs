using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.SearchViews;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Payments
{
    public partial class PaymentsView : Form, ClientSearchingForm, BillSearchingForm
    {
        public Cliente CurrentClient { get; set; }
        public Factura CurrentBill { get; set; }
        private BindingList<Factura> BillsToPay { get; set; }
        private PaymentsViewVM viewModel = new PaymentsViewVM();

        public PaymentsView()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Branch.Text = Login.userSubsidiary.Nombre;
            //this.fechaCobro.Value = DateTime.Now;
            this.PaymentDate.Value = Login.SystemDate;
            BillsToPay = new BindingList<Factura>();

            List<TextValuePair> paymentMethodsForDropDown = new List<TextValuePair>();
            List<FormaDePago> paymentMethods = viewModel.GetPaymentMethods().ToList();


            foreach (FormaDePago item in paymentMethods)
            {
                paymentMethodsForDropDown.Add(new TextValuePair(item.Nombre, (int)item.idFormaPago));
            }

            PaymentMethod.DataSource = paymentMethodsForDropDown;
            PaymentMethod.DisplayMember = "Text";
            PaymentMethod.ValueMember = "Value";
            BillsList.DataSource = BillsToPay;
            FormatDataGrid();
        }

        #region Events
        private void RegistroPagos_Shown(object sender, EventArgs e)
        {

        }

        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            FindClientsView view = new FindClientsView();

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            if(dialogResult == DialogResult.OK)
                this.Client.Text = CurrentClient.Nombre[0] + ". " + CurrentClient.Apellido;
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            if (Validation.EmptyTextBox(this.Client))
            {
                MessageBox.Show(this, "Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<decimal> BillsIDs = new List<decimal>();
            foreach (Factura bill in BillsToPay)
            {
                BillsIDs.Add(bill.idFactura);
            }

            FindBillsView view = new FindBillsView(CurrentClient, BillsIDs.ToArray());

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            if(dialogResult == DialogResult.OK)
                BillsToPay.Add(CurrentBill);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;

            viewModel.CreateNewPayment(CurrentClient.idCliente, Convert.ToDecimal(this.PaymentMethod.SelectedValue), BillsToPay.ToList());
            MessageBox.Show(this, "El pago ha sido realizado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private bool WrongOrEmptyFields()
        {
            if (this.CurrentClient == null)
            {
                MessageBox.Show(this, "Debe seleccionar un cliente antes de registrar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (Validation.NotSelectedComboBox(this.PaymentMethod).Count != 0)
            {
                MessageBox.Show(this, "Debe especificar un metodo de pago antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if ((BillsToPay == null) || (BillsToPay.Count == 0))
            {
                MessageBox.Show(this, "Debe agregar una factura antes de registrar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void FormatDataGrid()
        {
            this.BillsList.ClearSelection();
            this.BillsList.Columns["idFactura"].Visible = false;
            this.BillsList.Columns["Cliente"].Visible = false;
            this.BillsList.Columns["Empresa"].Visible = false;
            this.BillsList.Columns["Cliente1"].Visible = false;
            this.BillsList.Columns["Empresa1"].Visible = false;
            this.BillsList.Columns["Pagada"].Visible = false;
            this.BillsList.Columns["Activa"].Visible = false;
            this.BillsList.Columns["Rendida"].Visible = false;
            this.BillsList.Columns["FacturasPago"].Visible = false;
            this.BillsList.Columns["FacturasRendicion"].Visible = false;
            this.BillsList.Columns["Item_Factura"].Visible = false;
        }
        #endregion
    }
}
