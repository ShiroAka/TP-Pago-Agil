using System;
using System.Windows.Forms;
using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;

namespace PagoAgil.Bills
{
    public partial class Bill_ItemsView : Form
    {
        private Bill_ItemsViewVM viewModel = new Bill_ItemsViewVM();

        public Bill_ItemsView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Events
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
                return;

            ((BillsView)this.Owner).CurrentBillItem = viewModel.CreateNewItem(this._Name.Text, this.Quantity.Value, this.Value.Value); ;

            MessageBox.Show(this, "Item agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private bool EmptyFields()
        {
            if (Validation.EmptyTextBox(this._Name))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (Validation.ZeroedNumericUpDown(this.Quantity, this.Value).Count != 0)
            {
                MessageBox.Show(this, "Los campos \"Cantidad\" y \"Monto\" deben contener un valor distinto de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
        #endregion
    }
}
