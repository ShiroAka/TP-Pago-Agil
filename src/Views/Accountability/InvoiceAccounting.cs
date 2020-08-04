using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Accountability
{
    public partial class BillAccounting : Form
    {
        private InvoiceAccountingVM viewModel = new InvoiceAccountingVM();
        private bool EnterpriseSelected;

        public BillAccounting()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillEnterprisesDropDown();
        }

        #region Events
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (Validation.NotSelectedComboBox(this.Enterprises).Count != 0)
            {
                MessageBox.Show(this, "Debe seleccionar una empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal selectedEnterpriseId = Convert.ToDecimal(Enterprises.SelectedValue);

            decimal totalAccountingValue = viewModel.CalculateTotalAccountingValue(selectedEnterpriseId);
            decimal totalCommisionValue = viewModel.CalculateTotalCommisionValue();

            List<Factura> BillsToAccount = (viewModel.GetBillsToAccountByEnterprise(selectedEnterpriseId)).ToList();
            int BillsToAccountQuantity = BillsToAccount.Count;

            this.BillsQty.Text = BillsToAccountQuantity.ToString();
            //this.Date.Text = DateTime.Now.ToShortDateString();
            this.Date.Text = Login.SystemDate.ToShortDateString();
            this._TotalAccountingValue.Text = String.Format("{0:0.00}", totalAccountingValue);
            this.CommissionPercentage.Text = viewModel.CommisionPercentage.ToString();
            this.CommissionValue.Text = String.Format("{0:0.00}", totalCommisionValue);
            this.AccountedValue.Text = String.Format("{0:0.00}", (totalAccountingValue - totalCommisionValue));

            this.BillsList.DataSource = BillsToAccount;
            FormatDataGrid();

            EnterpriseSelected = true;
        }

        private void BtnDoAccounting_Click(object sender, EventArgs e)
        {
            if(!EnterpriseSelected)
            {
                MessageBox.Show("Seleccione una empresa antes de realizar la rendicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            viewModel.AccountInvoices(Convert.ToDecimal(this.Enterprises.SelectedValue));

            MessageBox.Show(this, "Facturas rendidas exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Enterprises_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BillsQty.Text = String.Empty;
            this.Date.Text = String.Empty;
            this._TotalAccountingValue.Text = String.Empty;
            this.CommissionPercentage.Text = String.Empty;
            this.CommissionValue.Text = String.Empty;
            this.AccountedValue.Text = String.Empty;
            this.BillsList.DataSource = null;

            EnterpriseSelected = false;
        }
        #endregion

        #region Methods
        private void FillEnterprisesDropDown()
        {
            IQueryable<Empresa> enterpriseQuery = viewModel.GetActiveEnterprises();

            List<TextValuePair> enterprisesList = new List<TextValuePair>();
            enterprisesList.Add(new TextValuePair("SELECCIONAR", 0));

            foreach (Empresa e in enterpriseQuery)
            {
                enterprisesList.Add(new TextValuePair(e.Nombre, (int)e.idEmpresa));
            }

            Enterprises.ValueMember = "Value";
            Enterprises.DisplayMember = "Text";
            Enterprises.DataSource = enterprisesList;
        }

        private void FormatDataGrid()
        {
            this.BillsList.Columns["idFactura"].Visible = false;
            this.BillsList.Columns["Empresa"].Visible = false;
            this.BillsList.Columns["Empresa1"].Visible = false;
            this.BillsList.Columns["Cliente"].Visible = false;
            this.BillsList.Columns["Cliente1"].Visible = false;
            this.BillsList.Columns["Activa"].Visible = false;
            this.BillsList.Columns["Pagada"].Visible = false;
            this.BillsList.Columns["Rendida"].Visible = false;
            this.BillsList.Columns["FacturasPago"].Visible = false;
            this.BillsList.Columns["FacturasRendicion"].Visible = false;
            this.BillsList.Columns["Item_Factura"].Visible = false;
        }
        #endregion
    }
}
