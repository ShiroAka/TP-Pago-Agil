using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.ViewModels;

namespace PagoAgil
{
    public partial class RoleSelectionView : Form
    {
        private RoleSelectionViewVM viewModel = new RoleSelectionViewVM();

        public RoleSelectionView()
        {
            InitializeComponent();
            this.CenterToScreen();

            List<Rol> roles = viewModel.GetUserRoles(Login.loggedUser.idUsuario).ToList();

            List<TextValuePair> comboBoxItems = new List<TextValuePair>();
            comboBoxItems.Add(new TextValuePair("SELECCIONAR", 0));

            foreach (Rol r in roles)
            {
                comboBoxItems.Add(new TextValuePair(r.Nombre, (int)r.idRol));
            }

            this.Roles.DataSource = comboBoxItems;
            Roles.DisplayMember = "Text";
            Roles.ValueMember = "Value";
        }

        #region Events
        private void BtnAccept_Click(object sender, EventArgs e)
        {           
            int selectedRoleId = Convert.ToInt32(Roles.SelectedValue);

            Login.userRole = viewModel.GetUserRole(Login.loggedUser.idUsuario, selectedRoleId);

            if (!Login.userRole.Nombre.ToUpper().Equals("ADMINISTRADOR"))
            {
                Login.userSubsidiary = viewModel.GetUserSubsidiary(Login.loggedUser.idUsuario);
            }

            MainView view = new MainView();
            this.Hide();
            view.Show(this);
        }

        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TextValuePair)this.Roles.SelectedItem).Value == 0)
            {
                this.BtnAccept.Enabled = false;
            }
            else
                this.BtnAccept.Enabled = true;
        }
        #endregion
    }
}
