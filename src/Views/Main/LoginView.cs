using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil
{
    public partial class LoginView : Form
    {
        private int incorrectLogins;
        private string LastUsername { get; set; }
        private LoginViewVM viewModel = new LoginViewVM();

        public LoginView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Events
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Validation.EmptyTextBox(this.UserName) || Validation.EmptyTextBox(this.Password))
            {
                MessageBox.Show(this, "Debe ingresar un nombre de usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario user = Login.CheckUsername(this.UserName.Text);

            //Each user belongs to a single subsidiary. You may not login to an account for a deactivated subsidiary (I made no checks for that because when deactivating a subsidiary, all its users get deactivated)
                                    
            if ((user == null))
            {
                MessageBox.Show(this, "El nombre de usuario ingresado es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LastUsername = user.UserName;

            if (!Login.CheckPassword(this.Password.Text, user))
            {                         
                MessageBox.Show(this, "La contraseña ingresada es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                ++incorrectLogins;
                if (incorrectLogins == 3)
                {
                    MessageBox.Show(this, "Se ha alcanzado la cantidad maxima de intentos incorrectos. El usuario sera desactivado.\n\nContacte con un administrador para resolver su situacion.");

                    viewModel.DeactivateUser(user);
                }

                return;
            }

            Login.loggedUser = user;
            Login.GetConfigDate();
            int userRoles = viewModel.CountUserRoles(user.idUsuario); ;
                   
            if (userRoles > 1)
            {
                RoleSelectionView view = new RoleSelectionView();

                this.Hide();
                view.Show(this);
            }
            else if (userRoles == 1)
            {
                Login.userRole = viewModel.GetUserRole(user.idUsuario);

                if (!Login.userRole.Nombre.ToUpper().Equals("ADMINISTRADOR"))
                {
                    Login.userSubsidiary = viewModel.GetUserSubsidiary(user.idUsuario);
                }

                MainView view = new MainView();
                this.Hide();
                view.Show(this);
            }
            else
            {
                MessageBox.Show(this, "El usuario especificado no tiene roles asignados en el sistema.\nContacte un administrador para resolver su situacion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginView_Activated(object sender, EventArgs e)
        {
            this.Password.Text = String.Empty;
            this.UserName.Text = LastUsername;
        }

        private void UserName_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                BtnLogin_Click(sender, null);
        }

        private void Password_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                BtnLogin_Click(sender, null);
        }    
        #endregion
    }
}
