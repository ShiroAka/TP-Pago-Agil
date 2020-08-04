using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;
using System.Data.Entity.Infrastructure;

namespace PagoAgil.Enterprises
{
    public partial class EnterprisesView : Form
    {
        private bool IsModifying;
        private decimal CurrentEnterpriseId;
        private EnterprisesViewVM viewModel = new EnterprisesViewVM();

        public EnterprisesView()
        {
            InitializeComponent();
            this.CenterToScreen();

            foreach (string element in viewModel.GetAreaNames())
            {
                this.Area.Items.Add(element);
            }

            IsModifying = false;
        }

        public EnterprisesView(Empresa enterprise)
        {
            InitializeComponent();
            this.CenterToScreen();

            IsModifying = true;

            CurrentEnterpriseId = enterprise.idEmpresa;
            string enterpriseRubro = viewModel.GetEnterpriseArea(enterprise.Rubro).Nombre;

            this.Text = "Modificar Empresa";
            this._Name.Text = enterprise.Nombre;
            this.Address.Text = enterprise.Direccion;
            this.CUIT.Text = this.ConvertCuitToViewFormat(enterprise.Cuit);
            //enterpriseOriginalCuit = this.formatModelCUIT(empresa.Cuit);
            this.Area.Items.Insert(0, enterpriseRubro);
            int value = 0;

            foreach (string elemento in viewModel.GetAreaNames())
            {
                if (elemento != enterpriseRubro)
                {
                    this.Area.Items.Insert(value, elemento);
                }
                value++;
            }
            this.Area.SelectedIndex = 0;
        }

        #region Events
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (IsModifying)
            {
                MessageBox.Show(this, "La Empresa no se ha modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (EmptyFields() || CuitIsWrong())
                return;

            if (IsModifying)
            {
                ModifyExistingEnterprise();
            }
            else
            {
                CreateNewEnterprise();
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private bool EmptyFields()
        {
            List<Control> wrongControls = Validation.EmptyTextBoxes(this._Name, this.Address, this.CUIT);

            if (wrongControls.Count != 0)
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (String.IsNullOrEmpty((string)this.Area.SelectedItem))
            {
                MessageBox.Show(this, "Debe seleccionar un Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            return false;
        }

        private bool CuitIsWrong()
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

        private void CreateNewEnterprise()
        {
            try
            {
                viewModel.CreateNewEnterprise(this._Name.Text, this.Address.Text, ConvertCuitToDBFormat(), (string)this.Area.SelectedItem);
                MessageBox.Show(this, "Empresa agregada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(this, "Ya existe una Empresa con el CUIT ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyExistingEnterprise()
        {
            try
            {
                viewModel.ModifyExistingEnterprise(CurrentEnterpriseId, this._Name.Text, this.Address.Text, ConvertCuitToDBFormat(), (string)this.Area.SelectedItem);
                MessageBox.Show(this, "Empresa editada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(this, "Ya existe una Empresa con el CUIT ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String ConvertCuitToDBFormat()
        {
            string dbCuit = this.CUIT.Text;
            dbCuit = dbCuit.Insert(2, "-");
            dbCuit = dbCuit.Insert(11, "-");
            return dbCuit;
        }

        private String ConvertCuitToViewFormat(String dbCuit)
        {
            return dbCuit.Replace(" ", String.Empty).Replace("-", String.Empty); ;
        }
        #endregion
    }
}