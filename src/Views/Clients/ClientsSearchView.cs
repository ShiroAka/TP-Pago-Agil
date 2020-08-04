using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Clients
{
    public partial class ClientsSearchView : Form
    {
        private IQueryable<Cliente> query;
        private ClientsSearchViewVM viewModel = new ClientsSearchViewVM();

        public ClientsSearchView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Events
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;

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

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Cliente selectedClient = (Cliente)this.SearchResults.CurrentRow.DataBoundItem;

            ClientsView view = new ClientsView(selectedClient);
            
            this.Hide();
            var dialogResult = view.ShowDialog(this);

            UpdateDataGrid(); //Changes not showing in the dataGridView when doing this. Even calling the 'BuildAndExecuteQuery()' method does not show changes
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Cliente selectedClient = (Cliente)this.SearchResults.CurrentRow.DataBoundItem;
            viewModel.DeleteClient(selectedClient);
            UpdateDataGrid();     
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
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
            List<Control> textBoxes = Validation.EmptyTextBoxes(this._Name, this.LastName, this.Identification);

            if (textBoxes.Count == 3)
            {
                MessageBox.Show(this, "Debe completar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if ((this.Identification.Text != String.Empty) && (Validation.NonNumericTextBoxText(this.Identification).Count != 0))
            {
                MessageBox.Show(this, "El campo \"DNI\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private List<Cliente> BuildAndExecuteQuery()
        {
            string clientName = Validation.EmptyTextBox(this._Name) ? "" : this._Name.Text;
            string clientLastName = Validation.EmptyTextBox(this.LastName) ? "" : this.LastName.Text;
            decimal identification = Validation.EmptyTextBox(this.Identification) ? 0 : decimal.Parse(this.Identification.Text);

            query = viewModel.BuildClientSearchQuery(clientName, clientLastName, identification);
            return query.ToList();
        }

        private void FormatDataGrid()
        {
            SearchResults.ClearSelection();
            SearchResults.Columns["Activo"].Visible = false;
            SearchResults.Columns["DatosErroneos"].Visible = false;
            SearchResults.Columns["Factura"].Visible = false;
            SearchResults.Columns["PagoDeFacturas"].Visible = false;
            SearchResults.Columns["idCliente"].Visible = false;
        }
        #endregion
    }
}
