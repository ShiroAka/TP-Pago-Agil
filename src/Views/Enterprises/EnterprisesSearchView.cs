using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Enterprises
{
    public partial class EnterprisesSearchView : Form
    {
        private EnterprisesSearchViewVM viewModel = new EnterprisesSearchViewVM();

        public EnterprisesSearchView()
        {
            InitializeComponent();
            this.CenterToScreen();

            List<TextValuePair> items = new List<TextValuePair>();
            items.Add(new TextValuePair("SELECCIONAR", 0));

            List<Rubro> areas = viewModel.GetAreas().ToList();

            foreach (Rubro area in areas)
            {
                items.Add(new TextValuePair(area.Nombre, (int)area.idRubro));
            }
            
            Item.DisplayMember = "Text";
            Item.ValueMember = "Value";
            Item.DataSource = items;
        }

        #region Events
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields())
                return;            
            
            SearchResults.DataSource = BuildAndExecuteQuery();
            FormatDataGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Empresa selectedEnterprise = (Empresa)this.SearchResults.CurrentRow.DataBoundItem;
            viewModel.DeleteEnterprise(selectedEnterprise);

            UpdateDataGrid();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Empresa selectedEnterprise = (Empresa)this.SearchResults.CurrentRow.DataBoundItem;

            EnterprisesView view = new EnterprisesView(selectedEnterprise);

            this.Hide();
            var dialogResult = view.ShowDialog(this);

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
        
        private void resultadosBusqueda_SelectionChanged(object sender, EventArgs e)
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
        #endregion

        #region Methods
        private void FormatDataGrid()
        {
            SearchResults.ClearSelection();
            SearchResults.Columns["idEmpresa"].Visible = false;
            SearchResults.Columns["Direccion"].Visible = false;
            SearchResults.Columns["Activa"].Visible = false;
            SearchResults.Columns["Rubro"].Visible = false;
            SearchResults.Columns["Factura"].Visible = false;
            SearchResults.Columns["Rendicion"].Visible = false;
            SearchResults.Columns["Rubro1"].DataPropertyName = "Rubro1.Nombre"; //With the above event I can get that property's property
            SearchResults.Columns["Rubro1"].HeaderText = "Rubro";
        }

        private void UpdateDataGrid()
        {
            SearchResults.DataSource = null;
            SearchResults.DataSource = BuildAndExecuteQuery();
            FormatDataGrid();
        }

        private bool WrongOrEmptyFields()
        {          
            if ((Validation.EmptyTextBoxes(this._Name, this.CUIT).Count == 2) && (Validation.NotSelectedComboBox(this.Item).Count != 0))
            {
                MessageBox.Show(this, "Debe completar al menos un campo o seleccionar un rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if(this.CUIT.Text != string.Empty)
                return IsCuitWrong();

            return false;
        }

        private bool IsCuitWrong()
        {
            long n;

            if (!long.TryParse(this.CUIT.Text, out n))
            {
                MessageBox.Show(this, "El campo \"CUIT\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (this.CUIT.Text.Length != 11)
            {
                MessageBox.Show(this, "El campo \"CUIT\" debe contener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private List<Empresa> BuildAndExecuteQuery()
        {
            string enterpriseName = Validation.EmptyTextBox(this._Name) ? "" : this._Name.Text;
            string cuit = Validation.EmptyTextBox(CUIT) ? "" : ConvertCuitToDBFormat();
            decimal areaId = Validation.NotSelectedComboBox(this.Item).Any() ? Convert.ToDecimal(this.Item.SelectedValue) : 0;

            IQueryable<Empresa> query = viewModel.BuildEnterpriseSearchQuery(enterpriseName, cuit, areaId);
            return query.ToList();
        }
        

        private String ConvertCuitToDBFormat()
        {
            string dbCuit = this.CUIT.Text;
            dbCuit = dbCuit.Insert(2, "-");
            dbCuit = dbCuit.Insert(11, "-");
            return dbCuit;
        }
        #endregion
    }
}