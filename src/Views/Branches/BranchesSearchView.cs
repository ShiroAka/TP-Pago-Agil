using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PagoAgil.Branches
{
    public partial class BranchesSearchView : Form
    {
        private IQueryable<Sucursal> query;
        private BranchesSearchViewVM viewModel = new BranchesSearchViewVM();

        public BranchesSearchView()
        {
            InitializeComponent();
            this.CenterToScreen();
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
            Sucursal selectedBranchOffice = (Sucursal)this.SearchResults.CurrentRow.DataBoundItem;

            BranchesView view = new BranchesView(selectedBranchOffice);

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            UpdateDataGrid(); //Changes not showing in the dataGridView when doing this. Even calling the 'BuildAndExecuteQuery()' method does not show changes
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Sucursal selectedBanchOffice = (Sucursal)this.SearchResults.CurrentRow.DataBoundItem;

            viewModel.DeleteBranchOffice(selectedBanchOffice);

            UpdateDataGrid();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        
        private void UpdateDataGrid()
        {
            this.SearchResults.DataSource = BuildAndExecuteQuery();
            FormatDataGrid();
        }
        private bool WrongOrEmptyFields()
        {
            List<Control> textBoxes = Validation.EmptyTextBoxes(this._Name, this.Address, this.ZipCode);

            if (textBoxes.Count == 3)
            {
                MessageBox.Show(this, "Debe completar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private List<Sucursal> BuildAndExecuteQuery()
        {
            string branchOfficeName = Validation.EmptyTextBox(this._Name) ? "" : this._Name.Text;
            string branchOfficeAddress= Validation.EmptyTextBox(this.Address) ? "" : this.Address.Text;
            decimal branchOfficeZipCode = Validation.EmptyTextBox(this.ZipCode) ? 0 : decimal.Parse(this.ZipCode.Text);
                        
            query = viewModel.BuildSearchQuery(branchOfficeName, branchOfficeAddress, branchOfficeZipCode);   
            return query.ToList();
        }

        private void FormatDataGrid()
        {
            SearchResults.ClearSelection();
            SearchResults.Columns["idSucursal"].Visible = false;
            SearchResults.Columns["Activa"].Visible = false;
            SearchResults.Columns["UsuariosSucursal"].Visible = false;
            SearchResults.Columns["PagosFactura"].Visible = false;
            
        }      
    }
}
