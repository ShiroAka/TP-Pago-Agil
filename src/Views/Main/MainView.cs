#region Importar Vistas
using PagoAgil.Clients;
using PagoAgil.Enterprises;
using PagoAgil.Bills;
using PagoAgil.Roles;
using PagoAgil.Branches;
using PagoAgil.BillReturn;
using PagoAgil.StatisticalLists;
using PagoAgil.Payments;
using PagoAgil.Accountability;
using PagoAgil.Areas;
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.ViewModels;

namespace PagoAgil
{
    public partial class MainView : Form
    {
        private MainViewVM viewModel = new MainViewVM();
        
        public MainView()
        {
            InitializeComponent();
            this.CenterToScreen();

            //This distinction is because administrators and collectors have a fixed set of permissions, but 
            //other roles don't have fixed permissions

            if (Login.userRole.Nombre.ToUpper() == "COBRADOR")
            {
                //TabControl tabs cannot be hidden, they have to be added or removed
                this.permissions.TabPages.Remove(this.administrator);
                this.permissions.TabPages.Remove(this.otherRole);
            }
            else if (Login.userRole.Nombre.ToUpper() == "ADMINISTRADOR")
            {
                this.permissions.TabPages.Remove(this.collector);    //This is to avoid the admins to register payments
                this.permissions.TabPages.Remove(this.otherRole);
            }
            else
            {
                this.permissions.TabPages.Remove(this.administrator);
                this.permissions.TabPages.Remove(this.collector);

                //Gets the permissions list for the given user
                List<Funcionalidad> rolePermissions = viewModel.GetRolePermissions(Login.userRole.idRol).ToList();

                this.otherRole.Text = Login.userRole.Nombre;

                bool clientCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM CLIENTES");
                bool enterpriseCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM EMPRESAS");
                bool branchCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM SUCURSALES");
                bool billCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM FACTURAS");
                bool roleCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM ROLES");
                bool categoryCrudActive = rolePermissions.Exists(x => x.Nombre == "ABM RUBROS");
                bool canReturnBills = rolePermissions.Exists(x => x.Nombre == "DEVOLUCIONES");
                bool canAcceptPayments = rolePermissions.Exists(x => x.Nombre == "PAGOS");
                bool canAccountPayments = rolePermissions.Exists(x => x.Nombre == "RENDICIONES");
                bool canGetLists = rolePermissions.Exists(x => x.Nombre == "LISTADOS");


                btnAltaCli3.Visible = clientCrudActive;
                btnAltaEmpr2.Visible = enterpriseCrudActive;
                btnAltaFact3.Visible = billCrudActive;
                btnAltaRoles2.Visible = roleCrudActive;
                btnAltaRubros2.Visible = categoryCrudActive;
                btnAltaSucu2.Visible = branchCrudActive;
                btnBuscarCli3.Visible = clientCrudActive;
                btnBuscarEmpr2.Visible = enterpriseCrudActive;
                btnBuscarFact3.Visible = billCrudActive;
                btnBuscarRoles2.Visible = roleCrudActive;
                btnBuscarSucu2.Visible = branchCrudActive;
                btnDevolver3.Visible = canReturnBills;
                btnListados2.Visible = canGetLists;
                btnPagos2.Visible = canAcceptPayments;
                btnRendir2.Visible = canAccountPayments;

            }
        }

        #region Events
        private void BtnRolesView_Click(object sender, EventArgs e)
        {
            RolesView view = new RolesView();
            this.Hide();
            view.Show(this);
        }

        private void BtnEnterprisesView_Click(object sender, EventArgs e)
        {
            EnterprisesView view = new EnterprisesView();
            this.Hide();
            view.Show(this);
        }

        private void BtnBranchesView_Click(object sender, EventArgs e)
        {
            BranchesView view = new BranchesView();
            this.Hide();
            view.Show(this);
        }

        private void BtnRolesSearchView_Click(object sender, EventArgs e)
        {
            RolesSearchView view = new RolesSearchView();
            this.Hide();
            view.Show(this);
        }

        private void BtnBranchesSearchView_Click(object sender, EventArgs e)
        {
            BranchesSearchView view = new BranchesSearchView();
            this.Hide();
            view.Show(this);
        }

        private void BtnEnterprisesSearchView_Click(object sender, EventArgs e)
        {
            EnterprisesSearchView view = new EnterprisesSearchView();
            this.Hide();
            view.Show(this);
        }

        private void BtnStatisticalLists_Click(object sender, EventArgs e)
        {
            StatisticalListsView view = new StatisticalListsView();
            this.Hide();
            view.Show(this);
        }

        private void BtnBillAccounting_Click(object sender, EventArgs e)
        {
            BillAccounting view = new BillAccounting();
            this.Hide();
            view.Show(this);
        }

        private void BtnBillReturnView_Click(object sender, EventArgs e)
        {
            BillReturnView view = new BillReturnView();
            this.Hide();
            view.Show(this);
        }

        private void BtnClientsView_Click(object sender, EventArgs e)
        {
            ClientsView view = new ClientsView();
            this.Hide();
            view.Show(this);
        }

        private void BtnBillsView_Click(object sender, EventArgs e)
        {
            BillsView view = new BillsView();
            this.Hide();
            view.Show(this);
        }

        private void BtnClientsSearchView_Click(object sender, EventArgs e)
        {
            ClientsSearchView view = new ClientsSearchView();
            this.Hide();
            view.Show(this);
        }

        private void BtnBillsSearchView_Click(object sender, EventArgs e)
        {
            BillSearchView view = new BillSearchView();
            this.Hide();
            view.Show(this);
        }

        private void BtnPaymentsView_Click(object sender, EventArgs e)
        {
            PaymentsView view = new PaymentsView();
            this.Hide();
            view.Show(this);
        }

        private void BtnAreasView_Click(object sender, EventArgs e)
        {
            AreasView view = new AreasView();
            this.Hide();
            view.Show(this);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login.loggedUser = null;
            Login.userRole = null;
            Login.userSubsidiary = null;

            this.Hide();
            if (this.Owner.GetType().Equals(typeof(RoleSelectionView)))
            {
                this.Owner.Owner.Show();
                this.Owner.Close(); //This closes this form's parent form and all its child forms/controls
            }
            else    //This form's parent form is 'Login'
            {
                this.Owner.Show();
                this.Close();
            }  
        }
        #endregion  
    }
}
