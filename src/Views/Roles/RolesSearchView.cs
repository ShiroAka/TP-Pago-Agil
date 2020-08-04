using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Roles
{
    public partial class RolesSearchView : Form
    {
        private RolesSearchViewVM viewModel = new RolesSearchViewVM();
        private BindingList<Funcionalidad> permissions;

        public RolesSearchView()
        {
            InitializeComponent();
            this.BtnSearch.Enabled = false;

            List<TextValuePair> roleNames = new List<TextValuePair>();
            roleNames.Add(new TextValuePair("SELECCIONAR", 0));

            List<Rol> rolesList = viewModel.GetRoles().ToList();

            foreach (Rol role in rolesList)
            {
                roleNames.Add(new TextValuePair(role.Nombre, (int)role.idRol));
            }

            RoleName.DataSource = roleNames;
            RoleName.DisplayMember = "Text";
            RoleName.ValueMember = "Value";

            permissions = new BindingList<Funcionalidad>();
            RolePermissionsList.DataSource = permissions;
            FormatDataGrid();
        }

        #region Events
        private void RoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validation.NotSelectedComboBox(this.RoleName).Count == 0)
                this.BtnSearch.Enabled = true;
            else
                this.BtnSearch.Enabled = false;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            decimal selectedRoleID = ((TextValuePair)RoleName.SelectedItem).Value;

            Rol role = viewModel.GetRoleById(selectedRoleID);

            RolesView view = new RolesView(role);

            this.Hide();
            view.Show(this);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            permissions.Clear();
            decimal selectedRoleID = ((TextValuePair)RoleName.SelectedItem).Value;

            List<Funcionalidad> rolePermissions = viewModel.GetRolePermissions(selectedRoleID).ToList();

            

            foreach (Funcionalidad permission in rolePermissions)
            {
                permissions.Add(permission);
            }

            this.BtnDelete.Enabled = true;
            this.BtnModify.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            decimal selectedRoleID = ((TextValuePair)RoleName.SelectedItem).Value;

            viewModel.DeleteRole(selectedRoleID);

            MessageBox.Show(this, "Rol dado de baja exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private void FormatDataGrid()
        {
            RolePermissionsList.ClearSelection();
            RolePermissionsList.Columns["idFuncionalidad"].Visible = false;
            RolePermissionsList.Columns["FuncionalidadesRol"].Visible = false;
        }
        #endregion
    }
}
