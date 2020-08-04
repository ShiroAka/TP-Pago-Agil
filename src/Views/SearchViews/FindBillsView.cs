using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.SearchViews
{
    public partial class FindBillsView : Form, ClientSearchingForm
    {       
        public Cliente CurrentClient { get; set; }
        private FindBillsViewVM viewModel = new FindBillsViewVM();
        private bool ClientWasPassed { get; set; }
        private decimal[] ParentViewBillIds { get; set;}

        public FindBillsView(decimal[] parentViewBills)
        {
            InitializeComponent();
            this.CenterToScreen();
            ClientWasPassed = false;
            ParentViewBillIds = parentViewBills;
        }

        public FindBillsView(Cliente client, decimal[] parentViewBills)
        {
            InitializeComponent();
            this.CenterToScreen();

            ClientWasPassed = true;
            this.BillNbr.Enabled = true;
            this.BtnSearch.Enabled = true;
            CurrentClient = client;
            ParentViewBillIds = parentViewBills;
        }

        private void BillSearchView_Load(object sender, EventArgs e)
        {
            BtnSelect.DialogResult = DialogResult.OK;
            BtnReturn.DialogResult = DialogResult.Cancel;

            if (!ClientWasPassed)
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

                foreach (Empresa enterprise in viewModel.GetEnterprises())
                {
                    enterprises.Add(new TextValuePair(enterprise.Nombre, (int)enterprise.idEmpresa));
                }

                Enterprise.DisplayMember = "Text";
                Enterprise.ValueMember = "Value";
                Enterprise.DataSource = enterprises;
            }
            else
            {
                Enterprise.Enabled = false;
                Client.Enabled = false;

                List<TextValuePair> searchFilters = new List<TextValuePair>();
                searchFilters.Add(new TextValuePair("Nº Factura", 1));

                SearchMethod.DataSource = searchFilters;
                SearchMethod.DisplayMember = "Text";
                SearchMethod.ValueMember = "Value";
                BtnFindClient.Enabled = false;

                IQueryable<Factura> billsList = viewModel.GetClientBills(CurrentClient.idCliente);
                List<Factura> billsNotInParentView = billsList.Where(x => !ParentViewBillIds.Contains(x.idFactura)).ToList();

                SearchResults.DataSource = billsNotInParentView;
                FormatDataGrid();
            }
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
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;

            SearchResults.Refresh();
            List<Factura> billsList = BuildAndExecuteQuery();

            //From the query list, remove all those bills whose ids are in the given ids list (ExistentBills). That means this will remove all bills that were selected before.
            billsList.RemoveAll(x => ParentViewBillIds.Contains(x.idFactura));
            SearchResults.DataSource = billsList;
            FormatDataGrid();
        }

        private void SearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (SearchResults.SelectedRows.Count == 0)
            {
                this.BtnSelect.Enabled = false;
            }
            else
            {
                this.BtnSelect.Enabled = true;
            }
        }

        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            FindClientsView view = new FindClientsView();

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            //Without this, it will try to do the following after clicking the return button in the client search screen, and will throw a null pointer exception (CurrentClient will not be set)
            if (dialogResult == DialogResult.OK)
                this.Client.Text = CurrentClient.Nombre[0] + ". " + CurrentClient.Apellido;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (SearchResults.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Factura selectedBill = (Factura)this.SearchResults.CurrentRow.DataBoundItem;

            ((BillSearchingForm)this.Owner).CurrentBill = selectedBill;

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
            SearchResults.DataSource = BuildAndExecuteQuery();
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
            decimal billNbr = ((int)this.SearchMethod.SelectedValue == 1) ? decimal.Parse(this.BillNbr.Text) : 0;
            decimal enterpriseId = !Validation.NotSelectedComboBox(this.Enterprise).Any() ? Convert.ToDecimal(this.Enterprise.SelectedValue) : 0;
            decimal clientId = (ClientWasPassed || !Validation.EmptyTextBox(this.Client)) ? CurrentClient.idCliente : 0;

            IQueryable<Factura> Query = viewModel.BuildFindBillsViewSearchQuery(billNbr, enterpriseId, clientId, ClientWasPassed);
            return Query.ToList();
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
