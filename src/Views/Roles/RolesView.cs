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
    public partial class RolesView : Form
    {        
        private decimal CurrentRoleId { get; set; }
        private BindingList<Funcionalidad> PermissionsList;
        private bool IsModifying;
        private RolesViewVM viewModel = new RolesViewVM();

        public RolesView()
        {
            InitializeComponent();
            this.CenterToScreen();

            IsModifying = false;
            PermissionsList = new BindingList<Funcionalidad>();

            List<TextValuePair> permissionsListForDropdown = new List<TextValuePair>();
            permissionsListForDropdown.Add(new TextValuePair("SELECCIONAR", 0));

            List<Funcionalidad> permissions = viewModel.GetPermissions().ToList();

            foreach (Funcionalidad permission in permissions)
            {
                permissionsListForDropdown.Add(new TextValuePair(permission.Nombre, (int)permission.idFuncionalidad));
            }

            PermissionToAdd.DataSource = permissionsListForDropdown;
            PermissionToAdd.DisplayMember = "Text";
            PermissionToAdd.ValueMember = "Value";
            RolePermissions.DataSource = PermissionsList;
            FormatDataGrid();
        }

        public RolesView(Rol role)
        {
            InitializeComponent();
            this.CenterToScreen();

            IsModifying = true;
            CurrentRoleId = role.idRol;
            PermissionsList = new BindingList<Funcionalidad>();

            List<TextValuePair> permissionsListForDropdown = new List<TextValuePair>();
            permissionsListForDropdown.Add(new TextValuePair("SELECCIONAR", 0));

            List<Funcionalidad> permissions = viewModel.GetPermissions().ToList();

            foreach (Funcionalidad permission in permissions)
            {
                permissionsListForDropdown.Add(new TextValuePair(permission.Nombre, (int)permission.idFuncionalidad));
            }

            List<Funcionalidad> rolePermissions = viewModel.GetRolePermissions(role.idRol).ToList();

            foreach (Funcionalidad permission in rolePermissions)
            {
                PermissionsList.Add(permission);
            }

            this.RoleName.Text = role.Nombre;

            PermissionToAdd.DataSource = permissions;
            PermissionToAdd.DisplayMember = "Text";
            PermissionToAdd.ValueMember = "Value";
            RolePermissions.DataSource = PermissionsList;
            FormatDataGrid();
        }

        #region Events
        private void funcionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal selectedPermissionId = ((TextValuePair)PermissionToAdd.SelectedItem).Value;
            Funcionalidad func = PermissionsList.FirstOrDefault(x => x.idFuncionalidad == selectedPermissionId);    //Get the first object from the list that matches the 
                                                                                                                    //selected permission's id (if not, get a null value)            

            if (selectedPermissionId == 0)
            {
                this.BtnAddPermission.Enabled = false;
                this.BtnDeletePermission.Enabled = false;
            }

            if (func != null)    //If the selected value is in the list, I can delete it
            {
                this.BtnAddPermission.Enabled = false;
                this.BtnDeletePermission.Enabled = true;
            }
            else if (selectedPermissionId != 0)     // Else, I can add that permission
            {
                this.BtnAddPermission.Enabled = true;
                this.BtnDeletePermission.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!IsModifying)
                CreateNewRole();
            else
                ModifyExistingRole();

            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal selectedPermissionID = Convert.ToDecimal(PermissionToAdd.SelectedValue);

            Funcionalidad permission = viewModel.GetPermission(selectedPermissionID);
            PermissionsList.Add(permission);

            this.BtnAddPermission.Enabled = false;
            this.BtnDeletePermission.Enabled = true;
        }

        private void btnDeleteFunc_Click(object sender, EventArgs e)
        {
            decimal selectedPermissionID = Convert.ToDecimal(PermissionToAdd.SelectedValue);

            Funcionalidad permission = PermissionsList.First(x => x.idFuncionalidad == selectedPermissionID);
            PermissionsList.Remove(permission);

            this.BtnAddPermission.Enabled = true;
            this.BtnDeletePermission.Enabled = false;
        }
        #endregion

        #region Methods
        private void ModifyExistingRole()
        {
            if (WrongOrEmptyFields())
                return;

            viewModel.ModifyExistingRole(CurrentRoleId, this.RoleName.Text, PermissionsList.ToList());

            MessageBox.Show(this, "Rol modificado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateNewRole()
        {
            decimal selectedPermissionID = ((TextValuePair)this.PermissionToAdd.SelectedItem).Value;
            Rol role = viewModel.GetRoleByName(this.RoleName.Text);

            if (role != null)
            {
                if (role.Activo == false)
                {
                    DialogResult messageBoxResult = MessageBox.Show(this, "El rol que desea crear ya existe, pero fue dado de baja.\n¿Desea darlo de alta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        viewModel.ReactivateRole(role);
                        MessageBox.Show(this, "El rol fue dado de alta exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Ya existe un rol con el nombre ingresado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                viewModel.CreateNewRole(this.RoleName.Text, PermissionsList.ToList());
                MessageBox.Show(this, "Rol agregado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool WrongOrEmptyFields()
        {
            if (Validation.EmptyTextBox(this.RoleName))
            { 
                MessageBox.Show(this, "El rol debe tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (PermissionsList.Count == 0)
            {
                MessageBox.Show(this, "Debe agregar un permiso antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void FormatDataGrid()
        {
            RolePermissions.ClearSelection();
            RolePermissions.Columns["idFuncionalidad"].Visible = false;
            RolePermissions.Columns["FuncionalidadesRol"].Visible = false;
        }
        #endregion
    }
}
