namespace PagoAgil.Roles
{
    partial class RolesView
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddPermission = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PermissionToAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeletePermission = new System.Windows.Forms.Button();
            this.RolePermissions = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RolePermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Funcionalidades del Rol";
            // 
            // BtnAddPermission
            // 
            this.BtnAddPermission.Enabled = false;
            this.BtnAddPermission.Location = new System.Drawing.Point(248, 52);
            this.BtnAddPermission.Name = "BtnAddPermission";
            this.BtnAddPermission.Size = new System.Drawing.Size(75, 23);
            this.BtnAddPermission.TabIndex = 11;
            this.BtnAddPermission.Text = "Agregar";
            this.BtnAddPermission.UseVisualStyleBackColor = true;
            this.BtnAddPermission.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Funcionalidad: ";
            // 
            // PermissionToAdd
            // 
            this.PermissionToAdd.CausesValidation = false;
            this.PermissionToAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermissionToAdd.FormattingEnabled = true;
            this.PermissionToAdd.Location = new System.Drawing.Point(102, 52);
            this.PermissionToAdd.Name = "PermissionToAdd";
            this.PermissionToAdd.Size = new System.Drawing.Size(125, 21);
            this.PermissionToAdd.TabIndex = 9;
            this.PermissionToAdd.SelectedIndexChanged += new System.EventHandler(this.funcionalidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre: ";
            // 
            // BtnDeletePermission
            // 
            this.BtnDeletePermission.Enabled = false;
            this.BtnDeletePermission.Location = new System.Drawing.Point(329, 52);
            this.BtnDeletePermission.Name = "BtnDeletePermission";
            this.BtnDeletePermission.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletePermission.TabIndex = 14;
            this.BtnDeletePermission.Text = "Quitar";
            this.BtnDeletePermission.UseVisualStyleBackColor = true;
            this.BtnDeletePermission.Click += new System.EventHandler(this.btnDeleteFunc_Click);
            // 
            // RolePermissions
            // 
            this.RolePermissions.AllowUserToAddRows = false;
            this.RolePermissions.AllowUserToDeleteRows = false;
            this.RolePermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolePermissions.Location = new System.Drawing.Point(15, 117);
            this.RolePermissions.Name = "RolePermissions";
            this.RolePermissions.ReadOnly = true;
            this.RolePermissions.Size = new System.Drawing.Size(389, 97);
            this.RolePermissions.TabIndex = 15;
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(102, 26);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(125, 20);
            this.RoleName.TabIndex = 16;
            this.RoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(319, 235);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 17;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(15, 235);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 18;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 270);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.RoleName);
            this.Controls.Add(this.RolePermissions);
            this.Controls.Add(this.BtnDeletePermission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddPermission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PermissionToAdd);
            this.Controls.Add(this.label1);
            this.Name = "RolesView";
            this.Text = "Modificar Rol";
            ((System.ComponentModel.ISupportInitialize)(this.RolePermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddPermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PermissionToAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeletePermission;
        private System.Windows.Forms.DataGridView RolePermissions;
        private System.Windows.Forms.TextBox RoleName;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;
    }
}