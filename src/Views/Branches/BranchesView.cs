using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace PagoAgil.Branches
{
    public partial class BranchesView : Form
    {
        private bool IsModifying;
        private decimal CurrentBranchOfficeId;
        private BranchesViewVM viewModel = new BranchesViewVM();

        public BranchesView()
        {
            InitializeComponent();
            this.CenterToScreen();
            IsModifying = false;
        }

        public BranchesView(Sucursal branch)
        {
            InitializeComponent();
            IsModifying = true;

            CurrentBranchOfficeId = branch.idSucursal;       

            this.Text = "Modificar Sucursal";
            this._Name.Text = branch.Nombre;
            this.Address.Text = branch.Direccion;
            this.ZipCode.Text = branch.Cod_Postal.ToString();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
                return;

            if (IsModifying)
            {
                ModifyExistingBranchOffice();
            }
            else
            {
                CreateNewBranchOffice();
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }      

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (IsModifying)
            {
                MessageBox.Show(this, "La sucursal no se ha modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private bool EmptyFields()
        {
            List<Control> wrongControls = Validation.EmptyTextBoxes(this._Name, this.Address, this.ZipCode);

            if (wrongControls.Count != 0)
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            long n;
            if (!long.TryParse(this.ZipCode.Text, out n))
            {
                MessageBox.Show(this, "El campo \"Codigo Postal\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }           
            return false;
        }

        private void ModifyExistingBranchOffice()
        {
            try
            {
                viewModel.ModifyExistingBranchOffice(CurrentBranchOfficeId, this._Name.Text, this.Address.Text, decimal.Parse(this.ZipCode.Text));
                MessageBox.Show(this, "Sucursal editada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(this, "Ya existe una Sucursal con el codigo postal ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewBranchOffice()
        { 
            try
            {
                viewModel.CreateNewBranchOffice(this._Name.Text, this.Address.Text, decimal.Parse(this.ZipCode.Text));
                MessageBox.Show(this, "Sucursal agregada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(this, "Ya existe una sucursal con el codgo postal ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
