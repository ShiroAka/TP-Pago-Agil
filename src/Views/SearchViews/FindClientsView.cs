using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.Clients;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.SearchViews
{
    public partial class FindClientsView : Form
    {
        private FindClientsViewVM viewModel = new FindClientsViewVM();

        public FindClientsView()
        {
            InitializeComponent();
            this.CenterToScreen();

            BtnReturn.DialogResult = DialogResult.Cancel;
            BtnSelect.DialogResult = DialogResult.OK;
        }

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
                this.BtnSelect.Enabled = false;
            }
            else
            {
                this.BtnSelect.Enabled = true;
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Cliente client = (Cliente)SearchResults.CurrentRow.DataBoundItem;
            ((ClientSearchingForm)this.Owner).CurrentClient = client;

            if (client.DatosErroneos == true)
            {
                ClientsView view = new ClientsView(client);

                this.Hide();
                var dialogResult = view.ShowDialog(this);
            }

            this.Hide();
            this.Owner.Show();
            this.Close();            
        }

        private bool WrongOrEmptyFields()
        {
            List<Control> textBoxes = Validation.EmptyTextBoxes(this.ClientName, this.ClientLastName, this.ClientIdentification);

            if (textBoxes.Count == 3)
            {
                MessageBox.Show(this, "Debe completar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if ((this.ClientIdentification.Text != String.Empty) && (Validation.NonNumericTextBoxText(this.ClientIdentification).Count != 0))
            {
                MessageBox.Show(this, "El campo \"DNI\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private List<Cliente> BuildAndExecuteQuery()
        {
            string clientName = Validation.EmptyTextBox(this.ClientName) ? "" : this.ClientName.Text;
            string clientLastName = Validation.EmptyTextBox(this.ClientLastName) ? "" : this.ClientLastName.Text;
            decimal identification = Validation.EmptyTextBox(this.ClientIdentification) ? 0 : decimal.Parse(this.ClientIdentification.Text);

            IQueryable<Cliente> query = viewModel.BuildClientSearchQuery(clientName, clientLastName, identification);
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
    }
}
