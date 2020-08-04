namespace PagoAgil
{
    partial class RoleSelectionView
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
            this.BtnAccept = new System.Windows.Forms.Button();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAccept
            // 
            this.BtnAccept.Enabled = false;
            this.BtnAccept.Location = new System.Drawing.Point(83, 57);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 0;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // Roles
            // 
            this.Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roles.FormattingEnabled = true;
            this.Roles.Location = new System.Drawing.Point(55, 25);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(121, 21);
            this.Roles.TabIndex = 1;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el rol con el que desea ingresar";
            // 
            // RoleSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 92);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.BtnAccept);
            this.Name = "RoleSelectionView";
            this.Text = "Seleccionar Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.Label label1;
    }
}