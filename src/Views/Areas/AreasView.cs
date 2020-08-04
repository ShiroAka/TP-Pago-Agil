using System;
using System.Windows.Forms;
using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;

namespace PagoAgil.Areas
{
    public partial class AreasView : Form
    {
        private AreasViewVM viewModel = new AreasViewVM();

        public AreasView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (Validation.EmptyTextBox(this._Name))
            {
                MessageBox.Show(this, "Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            viewModel.CreateNewArea(this._Name.Text);

            MessageBox.Show(this, "Rubro agregado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
