using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.SearchViews;
using PagoAgil.ViewModels;

namespace PagoAgil.Bills
{
    public partial class BillSearchView : Form, ClientSearchingForm
    {
        private BillsSearchViewVM viewModel = new BillsSearchViewVM();
        public Cliente CurrentClient { get; set; }
        private IQueryable<Factura> query;

        public BillSearchView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BillSearchView_Load(object sender, EventArgs e)
        {
            List<TextValuePair> search = new List<TextValuePair>();            
            search.Add(new TextValuePair("SELECCIONAR", 0));
            search.Add(new TextValuePair("Nº Factura", 1));
            search.Add(new TextValuePair("Empresa/Cliente", 2));

            SearchMethod.DisplayMember = "Text";
            SearchMethod.ValueMember = "Value";
            SearchMethod.DataSource = search;

            List<TextValuePair> enterprises = new List<TextValuePair>();
            enterprises.Add(new TextValuePair("SELECCIONAR", 0));

            IQueryable<Empresa> enterprisesList = viewModel.GetEnterprises();

            foreach (Empresa enterprise in enterprisesList)
            {
                enterprises.Add(new TextValuePair(enterprise.Nombre, (int)enterprise.idEmpresa));
            }

            Enterprise.DisplayMember = "Text";
            Enterprise.ValueMember = "Value";
            Enterprise.DataSource = enterprises;
        }

        #region Events
        private void SearchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TextValuePair)SearchMethod.SelectedItem).Value == 1)
            {
                BillNbr.Enabled = true;
                Client.Enabled = false;
                Enterprise.Enabled = false;
                BtnFindClient.Enabled = false;
                BtnSearch.Enabled = true;
            }
            else if (((TextValuePair)SearchMethod.SelectedItem).Value == 2)
            {
                BillNbr.Enabled = false;
                Client.Enabled = true;
                Enterprise.Enabled = true;
                BtnFindClient.Enabled = true;
                BtnSearch.Enabled = true;
            }
            else
            {
                Enterprise.Enabled = false;
                Client.Enabled = false;
                BtnFindClient.Enabled = false;
                BillNbr.Enabled = false;
                BtnSearch.Enabled = false;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;

            SearchResults.Refresh();
            SearchResults.DataSource = BuildAndExecuteQuery();
            FormatDataGrid();
        }

        private void SearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (SearchResults.SelectedRows.Count == 0)
            {
                this.BtnDelete.Enabled = false;
                this.BtnModify.Enabled = false;
            }
            else
            {
                this.BtnDelete.Enabled = true;
                this.BtnModify.Enabled = true;
            }
        }

        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            FindClientsView view = new FindClientsView();

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            //Without this, it will try to do the following after clicking the return button in the client search screen, and will throw a null pointer exception (CurrentClient will not be set)
            if(dialogResult == DialogResult.OK)
                this.Client.Text = CurrentClient.Nombre[0] + ". " + CurrentClient.Apellido;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Factura selectedBill = (Factura)this.SearchResults.CurrentRow.DataBoundItem;

            BillsView view = new BillsView(selectedBill);

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            UpdateDataGrid(); //Changes not showing in the dataGridView when doing this. Even calling the 'BuildAndExecuteQuery()' method does not show changes
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Factura selectedBill = (Factura)this.SearchResults.CurrentRow.DataBoundItem;

            viewModel.DeleteBill(selectedBill);            

            UpdateDataGrid();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void SearchResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /* If the DataPropertyName field doesn’t contain a dot character, then the actual value of the base data type property must be displayed, and no action is required.
               On the other hand, if the DataPropertyName field contains one or more dot characters, then it points to a property exposed by one of the bound class properties */

            if ((SearchResults.Rows[e.RowIndex].DataBoundItem != null) && (SearchResults.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = PropertyBinding.BindProperty(SearchResults.Rows[e.RowIndex].DataBoundItem, SearchResults.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
        #endregion

        #region Methods
        private void UpdateDataGrid()
        {
            SearchResults.DataSource = null;
            SearchResults.DataSource = query.ToList();
            FormatDataGrid();
        }

        private bool WrongOrEmptyFields()
        {
            if ((int)this.SearchMethod.SelectedValue == 1)
            {
                if (Validation.EmptyTextBox(this.BillNbr))
                {
                    MessageBox.Show(this, "El campo \"Nº Factura\" no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                if (Validation.NonNumericTextBoxText(this.BillNbr).Count != 0)
                {
                    MessageBox.Show(this, "El campo \"Nº Factura\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            else if ((int)this.SearchMethod.SelectedValue == 2)
            {
                if ((Validation.NotSelectedComboBox(Enterprise).Count != 0) && (Validation.EmptyTextBox(this.Client)))
                {
                    MessageBox.Show(this, "Debe seleccionar una empresa y/o un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            return false;
        }

        private List<Factura> BuildAndExecuteQuery()
        {
            if ((int)this.SearchMethod.SelectedValue == 1)
            {
                decimal billId = decimal.Parse(this.BillNbr.Text);
                query = viewModel.BuildSearchQuery(billId);
            }
            else
            {
                decimal clientId = Validation.EmptyTextBox(this.Client) ? 0 : CurrentClient.idCliente;
                decimal enterpriseId = (Validation.NotSelectedComboBox(this.Enterprise).Count == 0) ? Convert.ToDecimal(this.Enterprise.SelectedValue) : 0;

                query = viewModel.BuildSearchQuery(clientId, enterpriseId);
            }

            return query.ToList();
        }

        private void FormatDataGrid()
        {
            SearchResults.ClearSelection();
            SearchResults.Columns["idFactura"].Visible = false;
            SearchResults.Columns["Empresa"].Visible = false;
            SearchResults.Columns["Cliente"].Visible = false;
            SearchResults.Columns["Pagada"].Visible = false;
            SearchResults.Columns["Rendida"].Visible = false;
            SearchResults.Columns["Activa"].Visible = false;
            SearchResults.Columns["FacturasPago"].Visible = false;
            SearchResults.Columns["FacturasRendicion"].Visible = false;
            SearchResults.Columns["Item_Factura"].Visible = false;
            SearchResults.Columns["Empresa1"].DataPropertyName = "Empresa1.Nombre";
            SearchResults.Columns["Cliente1"].DataPropertyName = "Cliente1.Nombre";
        }
        #endregion
    }
}
