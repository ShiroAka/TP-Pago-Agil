namespace PagoAgil

{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.permissions = new System.Windows.Forms.TabControl();
            this.administrator = new System.Windows.Forms.TabPage();
            this.btnDevolver2 = new System.Windows.Forms.Button();
            this.btnRendir = new System.Windows.Forms.Button();
            this.btnListados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli2 = new System.Windows.Forms.Button();
            this.btnBuscarFact2 = new System.Windows.Forms.Button();
            this.btnBuscarEmpr = new System.Windows.Forms.Button();
            this.btnBuscarSucu = new System.Windows.Forms.Button();
            this.btnBuscarRoles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaCli2 = new System.Windows.Forms.Button();
            this.btnAltaFact2 = new System.Windows.Forms.Button();
            this.btnAltaRubros = new System.Windows.Forms.Button();
            this.btnAltaSucu = new System.Windows.Forms.Button();
            this.btnAltaRoles = new System.Windows.Forms.Button();
            this.btnAltaEmpr = new System.Windows.Forms.Button();
            this.collector = new System.Windows.Forms.TabPage();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnBuscarFact = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAltaCli = new System.Windows.Forms.Button();
            this.btnAltaFact = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.otherRole = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli3 = new System.Windows.Forms.Button();
            this.btnBuscarFact3 = new System.Windows.Forms.Button();
            this.btnBuscarEmpr2 = new System.Windows.Forms.Button();
            this.btnBuscarSucu2 = new System.Windows.Forms.Button();
            this.btnBuscarRoles2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAltaCli3 = new System.Windows.Forms.Button();
            this.btnAltaFact3 = new System.Windows.Forms.Button();
            this.btnAltaRubros2 = new System.Windows.Forms.Button();
            this.btnAltaSucu2 = new System.Windows.Forms.Button();
            this.btnAltaRoles2 = new System.Windows.Forms.Button();
            this.btnAltaEmpr2 = new System.Windows.Forms.Button();
            this.btnDevolver3 = new System.Windows.Forms.Button();
            this.btnRendir2 = new System.Windows.Forms.Button();
            this.btnListados2 = new System.Windows.Forms.Button();
            this.btnPagos2 = new System.Windows.Forms.Button();
            this.permissions.SuspendLayout();
            this.administrator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.collector.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.otherRole.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // permissions
            // 
            this.permissions.Controls.Add(this.administrator);
            this.permissions.Controls.Add(this.collector);
            this.permissions.Controls.Add(this.otherRole);
            this.permissions.Location = new System.Drawing.Point(12, 12);
            this.permissions.Name = "permissions";
            this.permissions.SelectedIndex = 0;
            this.permissions.Size = new System.Drawing.Size(537, 240);
            this.permissions.TabIndex = 1;
            // 
            // administrator
            // 
            this.administrator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.administrator.Controls.Add(this.btnDevolver2);
            this.administrator.Controls.Add(this.btnRendir);
            this.administrator.Controls.Add(this.btnListados);
            this.administrator.Controls.Add(this.groupBox2);
            this.administrator.Controls.Add(this.groupBox1);
            this.administrator.Location = new System.Drawing.Point(4, 22);
            this.administrator.Name = "administrator";
            this.administrator.Padding = new System.Windows.Forms.Padding(3);
            this.administrator.Size = new System.Drawing.Size(529, 214);
            this.administrator.TabIndex = 0;
            this.administrator.Text = "Administrador";
            // 
            // btnDevolver2
            // 
            this.btnDevolver2.Location = new System.Drawing.Point(255, 185);
            this.btnDevolver2.Name = "btnDevolver2";
            this.btnDevolver2.Size = new System.Drawing.Size(151, 23);
            this.btnDevolver2.TabIndex = 12;
            this.btnDevolver2.Text = "Devolver Facturas Cobradas";
            this.btnDevolver2.UseVisualStyleBackColor = true;
            this.btnDevolver2.Click += new System.EventHandler(this.BtnBillReturnView_Click);
            // 
            // btnRendir
            // 
            this.btnRendir.Location = new System.Drawing.Point(132, 185);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(117, 23);
            this.btnRendir.TabIndex = 9;
            this.btnRendir.Text = "Rendir Facturas";
            this.btnRendir.UseVisualStyleBackColor = true;
            this.btnRendir.Click += new System.EventHandler(this.BtnBillAccounting_Click);
            // 
            // btnListados
            // 
            this.btnListados.Location = new System.Drawing.Point(9, 185);
            this.btnListados.Name = "btnListados";
            this.btnListados.Size = new System.Drawing.Size(117, 23);
            this.btnListados.TabIndex = 8;
            this.btnListados.Text = "Listados Estadisticos";
            this.btnListados.UseVisualStyleBackColor = true;
            this.btnListados.Click += new System.EventHandler(this.BtnStatisticalLists_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCli2);
            this.groupBox2.Controls.Add(this.btnBuscarFact2);
            this.groupBox2.Controls.Add(this.btnBuscarEmpr);
            this.groupBox2.Controls.Add(this.btnBuscarSucu);
            this.groupBox2.Controls.Add(this.btnBuscarRoles);
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bajas y Modificaciones";
            // 
            // btnBuscarCli2
            // 
            this.btnBuscarCli2.Location = new System.Drawing.Point(6, 48);
            this.btnBuscarCli2.Name = "btnBuscarCli2";
            this.btnBuscarCli2.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarCli2.TabIndex = 11;
            this.btnBuscarCli2.Text = "Buscar Clientes";
            this.btnBuscarCli2.UseVisualStyleBackColor = true;
            this.btnBuscarCli2.Click += new System.EventHandler(this.BtnClientsSearchView_Click);
            // 
            // btnBuscarFact2
            // 
            this.btnBuscarFact2.Location = new System.Drawing.Point(123, 48);
            this.btnBuscarFact2.Name = "btnBuscarFact2";
            this.btnBuscarFact2.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarFact2.TabIndex = 12;
            this.btnBuscarFact2.Text = "Buscar Facturas";
            this.btnBuscarFact2.UseVisualStyleBackColor = true;
            this.btnBuscarFact2.Click += new System.EventHandler(this.BtnBillsSearchView_Click);
            // 
            // btnBuscarEmpr
            // 
            this.btnBuscarEmpr.Location = new System.Drawing.Point(283, 19);
            this.btnBuscarEmpr.Name = "btnBuscarEmpr";
            this.btnBuscarEmpr.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarEmpr.TabIndex = 10;
            this.btnBuscarEmpr.Text = "Buscar Empresas";
            this.btnBuscarEmpr.UseVisualStyleBackColor = true;
            this.btnBuscarEmpr.Click += new System.EventHandler(this.BtnEnterprisesSearchView_Click);
            // 
            // btnBuscarSucu
            // 
            this.btnBuscarSucu.Location = new System.Drawing.Point(6, 19);
            this.btnBuscarSucu.Name = "btnBuscarSucu";
            this.btnBuscarSucu.Size = new System.Drawing.Size(160, 23);
            this.btnBuscarSucu.TabIndex = 7;
            this.btnBuscarSucu.Text = "Buscar Sucursales";
            this.btnBuscarSucu.UseVisualStyleBackColor = true;
            this.btnBuscarSucu.Click += new System.EventHandler(this.BtnBranchesSearchView_Click);
            // 
            // btnBuscarRoles
            // 
            this.btnBuscarRoles.Location = new System.Drawing.Point(172, 19);
            this.btnBuscarRoles.Name = "btnBuscarRoles";
            this.btnBuscarRoles.Size = new System.Drawing.Size(105, 23);
            this.btnBuscarRoles.TabIndex = 9;
            this.btnBuscarRoles.Text = "Buscar Roles";
            this.btnBuscarRoles.UseVisualStyleBackColor = true;
            this.btnBuscarRoles.Click += new System.EventHandler(this.BtnRolesSearchView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaCli2);
            this.groupBox1.Controls.Add(this.btnAltaFact2);
            this.groupBox1.Controls.Add(this.btnAltaRubros);
            this.groupBox1.Controls.Add(this.btnAltaSucu);
            this.groupBox1.Controls.Add(this.btnAltaRoles);
            this.groupBox1.Controls.Add(this.btnAltaEmpr);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altas";
            // 
            // btnAltaCli2
            // 
            this.btnAltaCli2.Location = new System.Drawing.Point(6, 48);
            this.btnAltaCli2.Name = "btnAltaCli2";
            this.btnAltaCli2.Size = new System.Drawing.Size(111, 23);
            this.btnAltaCli2.TabIndex = 6;
            this.btnAltaCli2.Text = "Alta de Clientes";
            this.btnAltaCli2.UseVisualStyleBackColor = true;
            this.btnAltaCli2.Click += new System.EventHandler(this.BtnClientsView_Click);
            // 
            // btnAltaFact2
            // 
            this.btnAltaFact2.Location = new System.Drawing.Point(123, 48);
            this.btnAltaFact2.Name = "btnAltaFact2";
            this.btnAltaFact2.Size = new System.Drawing.Size(111, 23);
            this.btnAltaFact2.TabIndex = 7;
            this.btnAltaFact2.Text = "Alta de Facturas";
            this.btnAltaFact2.UseVisualStyleBackColor = true;
            this.btnAltaFact2.Click += new System.EventHandler(this.BtnBillsView_Click);
            // 
            // btnAltaRubros
            // 
            this.btnAltaRubros.Location = new System.Drawing.Point(260, 19);
            this.btnAltaRubros.Name = "btnAltaRubros";
            this.btnAltaRubros.Size = new System.Drawing.Size(105, 23);
            this.btnAltaRubros.TabIndex = 5;
            this.btnAltaRubros.Text = "Alta de Rubros";
            this.btnAltaRubros.UseVisualStyleBackColor = true;
            this.btnAltaRubros.Click += new System.EventHandler(this.BtnAreasView_Click);
            // 
            // btnAltaSucu
            // 
            this.btnAltaSucu.Location = new System.Drawing.Point(6, 19);
            this.btnAltaSucu.Name = "btnAltaSucu";
            this.btnAltaSucu.Size = new System.Drawing.Size(137, 23);
            this.btnAltaSucu.TabIndex = 2;
            this.btnAltaSucu.Text = "Alta de Sucursales";
            this.btnAltaSucu.UseVisualStyleBackColor = true;
            this.btnAltaSucu.Click += new System.EventHandler(this.BtnBranchesView_Click);
            // 
            // btnAltaRoles
            // 
            this.btnAltaRoles.Location = new System.Drawing.Point(149, 19);
            this.btnAltaRoles.Name = "btnAltaRoles";
            this.btnAltaRoles.Size = new System.Drawing.Size(105, 23);
            this.btnAltaRoles.TabIndex = 4;
            this.btnAltaRoles.Text = "Alta de Roles";
            this.btnAltaRoles.UseVisualStyleBackColor = true;
            this.btnAltaRoles.Click += new System.EventHandler(this.BtnRolesView_Click);
            // 
            // btnAltaEmpr
            // 
            this.btnAltaEmpr.Location = new System.Drawing.Point(371, 19);
            this.btnAltaEmpr.Name = "btnAltaEmpr";
            this.btnAltaEmpr.Size = new System.Drawing.Size(105, 23);
            this.btnAltaEmpr.TabIndex = 1;
            this.btnAltaEmpr.Text = "Alta de Empresas";
            this.btnAltaEmpr.UseVisualStyleBackColor = true;
            this.btnAltaEmpr.Click += new System.EventHandler(this.BtnEnterprisesView_Click);
            // 
            // collector
            // 
            this.collector.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.collector.Controls.Add(this.btnDevolver);
            this.collector.Controls.Add(this.groupBox3);
            this.collector.Controls.Add(this.groupBox4);
            this.collector.Controls.Add(this.btnPagos);
            this.collector.Location = new System.Drawing.Point(4, 22);
            this.collector.Name = "collector";
            this.collector.Padding = new System.Windows.Forms.Padding(3);
            this.collector.Size = new System.Drawing.Size(529, 214);
            this.collector.TabIndex = 1;
            this.collector.Text = "Cobrador";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(129, 161);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(151, 23);
            this.btnDevolver.TabIndex = 11;
            this.btnDevolver.Text = "Devolver Facturas Cobradas";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.BtnBillReturnView_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarCli);
            this.groupBox3.Controls.Add(this.btnBuscarFact);
            this.groupBox3.Location = new System.Drawing.Point(6, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 58);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bajas y Modificaciones";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(6, 19);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarCli.TabIndex = 1;
            this.btnBuscarCli.Text = "Buscar Clientes";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.BtnClientsSearchView_Click);
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.Location = new System.Drawing.Point(123, 19);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarFact.TabIndex = 2;
            this.btnBuscarFact.Text = "Buscar Facturas";
            this.btnBuscarFact.UseVisualStyleBackColor = true;
            this.btnBuscarFact.Click += new System.EventHandler(this.BtnBillsSearchView_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAltaCli);
            this.groupBox4.Controls.Add(this.btnAltaFact);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 59);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Altas";
            // 
            // btnAltaCli
            // 
            this.btnAltaCli.Location = new System.Drawing.Point(6, 19);
            this.btnAltaCli.Name = "btnAltaCli";
            this.btnAltaCli.Size = new System.Drawing.Size(111, 23);
            this.btnAltaCli.TabIndex = 0;
            this.btnAltaCli.Text = "Alta de Clientes";
            this.btnAltaCli.UseVisualStyleBackColor = true;
            this.btnAltaCli.Click += new System.EventHandler(this.BtnClientsView_Click);
            // 
            // btnAltaFact
            // 
            this.btnAltaFact.Location = new System.Drawing.Point(123, 19);
            this.btnAltaFact.Name = "btnAltaFact";
            this.btnAltaFact.Size = new System.Drawing.Size(111, 23);
            this.btnAltaFact.TabIndex = 3;
            this.btnAltaFact.Text = "Alta de Facturas";
            this.btnAltaFact.UseVisualStyleBackColor = true;
            this.btnAltaFact.Click += new System.EventHandler(this.BtnBillsView_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(12, 161);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(111, 23);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Registrar Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.BtnPaymentsView_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(452, 258);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Desconectarse";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // otherRole
            // 
            this.otherRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.otherRole.Controls.Add(this.btnPagos2);
            this.otherRole.Controls.Add(this.btnDevolver3);
            this.otherRole.Controls.Add(this.btnRendir2);
            this.otherRole.Controls.Add(this.btnListados2);
            this.otherRole.Controls.Add(this.groupBox5);
            this.otherRole.Controls.Add(this.groupBox6);
            this.otherRole.Location = new System.Drawing.Point(4, 22);
            this.otherRole.Name = "otherRole";
            this.otherRole.Padding = new System.Windows.Forms.Padding(3);
            this.otherRole.Size = new System.Drawing.Size(529, 214);
            this.otherRole.TabIndex = 2;
            this.otherRole.Text = "tabPage1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarCli3);
            this.groupBox5.Controls.Add(this.btnBuscarFact3);
            this.groupBox5.Controls.Add(this.btnBuscarEmpr2);
            this.groupBox5.Controls.Add(this.btnBuscarSucu2);
            this.groupBox5.Controls.Add(this.btnBuscarRoles2);
            this.groupBox5.Location = new System.Drawing.Point(3, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(483, 78);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bajas y Modificaciones";
            // 
            // btnBuscarCli3
            // 
            this.btnBuscarCli3.Location = new System.Drawing.Point(6, 48);
            this.btnBuscarCli3.Name = "btnBuscarCli3";
            this.btnBuscarCli3.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarCli3.TabIndex = 11;
            this.btnBuscarCli3.Text = "Buscar Clientes";
            this.btnBuscarCli3.UseVisualStyleBackColor = true;
            this.btnBuscarCli3.Click += new System.EventHandler(this.BtnClientsSearchView_Click);
            // 
            // btnBuscarFact3
            // 
            this.btnBuscarFact3.Location = new System.Drawing.Point(123, 48);
            this.btnBuscarFact3.Name = "btnBuscarFact3";
            this.btnBuscarFact3.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarFact3.TabIndex = 12;
            this.btnBuscarFact3.Text = "Buscar Facturas";
            this.btnBuscarFact3.UseVisualStyleBackColor = true;
            this.btnBuscarFact3.Click += new System.EventHandler(this.BtnBillsSearchView_Click);
            // 
            // btnBuscarEmpr2
            // 
            this.btnBuscarEmpr2.Location = new System.Drawing.Point(283, 19);
            this.btnBuscarEmpr2.Name = "btnBuscarEmpr2";
            this.btnBuscarEmpr2.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarEmpr2.TabIndex = 10;
            this.btnBuscarEmpr2.Text = "Buscar Empresas";
            this.btnBuscarEmpr2.UseVisualStyleBackColor = true;
            this.btnBuscarEmpr2.Click += new System.EventHandler(this.BtnEnterprisesSearchView_Click);
            // 
            // btnBuscarSucu2
            // 
            this.btnBuscarSucu2.Location = new System.Drawing.Point(6, 19);
            this.btnBuscarSucu2.Name = "btnBuscarSucu2";
            this.btnBuscarSucu2.Size = new System.Drawing.Size(160, 23);
            this.btnBuscarSucu2.TabIndex = 7;
            this.btnBuscarSucu2.Text = "Buscar Sucursales";
            this.btnBuscarSucu2.UseVisualStyleBackColor = true;
            this.btnBuscarSucu2.Click += new System.EventHandler(this.BtnBranchesSearchView_Click);
            // 
            // btnBuscarRoles2
            // 
            this.btnBuscarRoles2.Location = new System.Drawing.Point(172, 19);
            this.btnBuscarRoles2.Name = "btnBuscarRoles2";
            this.btnBuscarRoles2.Size = new System.Drawing.Size(105, 23);
            this.btnBuscarRoles2.TabIndex = 9;
            this.btnBuscarRoles2.Text = "Buscar Roles";
            this.btnBuscarRoles2.UseVisualStyleBackColor = true;
            this.btnBuscarRoles2.Click += new System.EventHandler(this.BtnRolesSearchView_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAltaCli3);
            this.groupBox6.Controls.Add(this.btnAltaFact3);
            this.groupBox6.Controls.Add(this.btnAltaRubros2);
            this.groupBox6.Controls.Add(this.btnAltaSucu2);
            this.groupBox6.Controls.Add(this.btnAltaRoles2);
            this.groupBox6.Controls.Add(this.btnAltaEmpr2);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(483, 81);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Altas";
            // 
            // btnAltaCli3
            // 
            this.btnAltaCli3.Location = new System.Drawing.Point(6, 48);
            this.btnAltaCli3.Name = "btnAltaCli3";
            this.btnAltaCli3.Size = new System.Drawing.Size(111, 23);
            this.btnAltaCli3.TabIndex = 6;
            this.btnAltaCli3.Text = "Alta de Clientes";
            this.btnAltaCli3.UseVisualStyleBackColor = true;
            this.btnAltaCli3.Click += new System.EventHandler(this.BtnClientsView_Click);
            // 
            // btnAltaFact3
            // 
            this.btnAltaFact3.Location = new System.Drawing.Point(123, 48);
            this.btnAltaFact3.Name = "btnAltaFact3";
            this.btnAltaFact3.Size = new System.Drawing.Size(111, 23);
            this.btnAltaFact3.TabIndex = 7;
            this.btnAltaFact3.Text = "Alta de Facturas";
            this.btnAltaFact3.UseVisualStyleBackColor = true;
            this.btnAltaFact3.Click += new System.EventHandler(this.BtnBillsView_Click);
            // 
            // btnAltaRubros2
            // 
            this.btnAltaRubros2.Location = new System.Drawing.Point(260, 19);
            this.btnAltaRubros2.Name = "btnAltaRubros2";
            this.btnAltaRubros2.Size = new System.Drawing.Size(105, 23);
            this.btnAltaRubros2.TabIndex = 5;
            this.btnAltaRubros2.Text = "Alta de Rubros";
            this.btnAltaRubros2.UseVisualStyleBackColor = true;
            this.btnAltaRubros2.Click += new System.EventHandler(this.BtnAreasView_Click);
            // 
            // btnAltaSucu2
            // 
            this.btnAltaSucu2.Location = new System.Drawing.Point(6, 19);
            this.btnAltaSucu2.Name = "btnAltaSucu2";
            this.btnAltaSucu2.Size = new System.Drawing.Size(137, 23);
            this.btnAltaSucu2.TabIndex = 2;
            this.btnAltaSucu2.Text = "Alta de Sucursales";
            this.btnAltaSucu2.UseVisualStyleBackColor = true;
            this.btnAltaSucu2.Click += new System.EventHandler(this.BtnBranchesView_Click);
            // 
            // btnAltaRoles2
            // 
            this.btnAltaRoles2.Location = new System.Drawing.Point(149, 19);
            this.btnAltaRoles2.Name = "btnAltaRoles2";
            this.btnAltaRoles2.Size = new System.Drawing.Size(105, 23);
            this.btnAltaRoles2.TabIndex = 4;
            this.btnAltaRoles2.Text = "Alta de Roles";
            this.btnAltaRoles2.UseVisualStyleBackColor = true;
            this.btnAltaRoles2.Click += new System.EventHandler(this.BtnRolesView_Click);
            // 
            // btnAltaEmpr2
            // 
            this.btnAltaEmpr2.Location = new System.Drawing.Point(371, 19);
            this.btnAltaEmpr2.Name = "btnAltaEmpr2";
            this.btnAltaEmpr2.Size = new System.Drawing.Size(105, 23);
            this.btnAltaEmpr2.TabIndex = 1;
            this.btnAltaEmpr2.Text = "Alta de Empresas";
            this.btnAltaEmpr2.UseVisualStyleBackColor = true;
            this.btnAltaEmpr2.Click += new System.EventHandler(this.BtnEnterprisesView_Click);
            // 
            // btnDevolver3
            // 
            this.btnDevolver3.Location = new System.Drawing.Point(252, 185);
            this.btnDevolver3.Name = "btnDevolver3";
            this.btnDevolver3.Size = new System.Drawing.Size(151, 23);
            this.btnDevolver3.TabIndex = 15;
            this.btnDevolver3.Text = "Devolver Facturas Cobradas";
            this.btnDevolver3.UseVisualStyleBackColor = true;
            this.btnDevolver3.Click += new System.EventHandler(this.BtnBillReturnView_Click);
            // 
            // btnRendir2
            // 
            this.btnRendir2.Location = new System.Drawing.Point(129, 185);
            this.btnRendir2.Name = "btnRendir2";
            this.btnRendir2.Size = new System.Drawing.Size(117, 23);
            this.btnRendir2.TabIndex = 14;
            this.btnRendir2.Text = "Rendir Facturas";
            this.btnRendir2.UseVisualStyleBackColor = true;
            this.btnRendir2.Click += new System.EventHandler(this.BtnBillAccounting_Click);
            // 
            // btnListados2
            // 
            this.btnListados2.Location = new System.Drawing.Point(6, 185);
            this.btnListados2.Name = "btnListados2";
            this.btnListados2.Size = new System.Drawing.Size(117, 23);
            this.btnListados2.TabIndex = 13;
            this.btnListados2.Text = "Listados Estadisticos";
            this.btnListados2.UseVisualStyleBackColor = true;
            this.btnListados2.Click += new System.EventHandler(this.BtnStatisticalLists_Click);
            // 
            // btnPagos2
            // 
            this.btnPagos2.Location = new System.Drawing.Point(409, 185);
            this.btnPagos2.Name = "btnPagos2";
            this.btnPagos2.Size = new System.Drawing.Size(111, 23);
            this.btnPagos2.TabIndex = 16;
            this.btnPagos2.Text = "Registrar Pagos";
            this.btnPagos2.UseVisualStyleBackColor = true;
            this.btnPagos2.Click += new System.EventHandler(this.BtnPaymentsView_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.permissions);
            this.Name = "MainView";
            this.Text = "Pago Agil";
            this.permissions.ResumeLayout(false);
            this.administrator.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.collector.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.otherRole.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl permissions;
        private System.Windows.Forms.TabPage administrator;
        private System.Windows.Forms.Button btnAltaRoles;
        private System.Windows.Forms.Button btnAltaSucu;
        private System.Windows.Forms.Button btnAltaEmpr;
        private System.Windows.Forms.TabPage collector;
        private System.Windows.Forms.Button btnRendir;
        private System.Windows.Forms.Button btnListados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarEmpr;
        private System.Windows.Forms.Button btnBuscarSucu;
        private System.Windows.Forms.Button btnBuscarRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnAltaFact;
        private System.Windows.Forms.Button btnBuscarFact;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnAltaCli;
        private System.Windows.Forms.Button btnAltaRubros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBuscarCli2;
        private System.Windows.Forms.Button btnBuscarFact2;
        private System.Windows.Forms.Button btnAltaCli2;
        private System.Windows.Forms.Button btnAltaFact2;
        private System.Windows.Forms.Button btnDevolver2;
        private System.Windows.Forms.TabPage otherRole;
        private System.Windows.Forms.Button btnPagos2;
        private System.Windows.Forms.Button btnDevolver3;
        private System.Windows.Forms.Button btnRendir2;
        private System.Windows.Forms.Button btnListados2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarCli3;
        private System.Windows.Forms.Button btnBuscarFact3;
        private System.Windows.Forms.Button btnBuscarEmpr2;
        private System.Windows.Forms.Button btnBuscarSucu2;
        private System.Windows.Forms.Button btnBuscarRoles2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAltaCli3;
        private System.Windows.Forms.Button btnAltaFact3;
        private System.Windows.Forms.Button btnAltaRubros2;
        private System.Windows.Forms.Button btnAltaSucu2;
        private System.Windows.Forms.Button btnAltaRoles2;
        private System.Windows.Forms.Button btnAltaEmpr2;
    }
}

