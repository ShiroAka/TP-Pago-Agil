namespace PagoAgil.Roles
{
    partial class RolesSearchView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RoleName = new System.Windows.Forms.ComboBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RolePermissionsList = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RolePermissionsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // RoleName
            // 
            this.RoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleName.FormattingEnabled = true;
            this.RoleName.Location = new System.Drawing.Point(76, 27);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(125, 21);
            this.RoleName.TabIndex = 1;
            this.RoleName.SelectedIndexChanged += new System.EventHandler(this.RoleName_SelectedIndexChanged);
            // 
            // BtnModify
            // 
            this.BtnModify.Enabled = false;
            this.BtnModify.Location = new System.Drawing.Point(128, 240);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "Modificar";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(238, 240);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Dar de Baja";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionalidades del Rol";
            // 
            // RolePermissionsList
            // 
            this.RolePermissionsList.AllowUserToAddRows = false;
            this.RolePermissionsList.AllowUserToDeleteRows = false;
            this.RolePermissionsList.CausesValidation = false;
            this.RolePermissionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolePermissionsList.Location = new System.Drawing.Point(12, 128);
            this.RolePermissionsList.Name = "RolePermissionsList";
            this.RolePermissionsList.ReadOnly = true;
            this.RolePermissionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RolePermissionsList.Size = new System.Drawing.Size(308, 97);
            this.RolePermissionsList.TabIndex = 6;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(15, 240);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoleName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(238, 87);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // RolesSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.RolePermissionsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Name = "RolesSearchView";
            this.Text = "Consultar Roles";
            ((System.ComponentModel.ISupportInitialize)(this.RolePermissionsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoleName;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RolePermissionsList;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearch;
    }
}