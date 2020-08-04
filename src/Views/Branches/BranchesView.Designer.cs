namespace PagoAgil.Branches
{
    partial class BranchesView
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this._Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Codigo Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Direccion:";
            // 
            // ZipCode
            // 
            this.ZipCode.Location = new System.Drawing.Point(90, 78);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(153, 20);
            this.ZipCode.TabIndex = 20;
            this.ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(90, 52);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(153, 20);
            this.Address.TabIndex = 19;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(90, 26);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(153, 20);
            this._Name.TabIndex = 18;
            this._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(187, 118);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 24;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 118);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 25;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BranchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.Address);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.label1);
            this.Name = "BranchesView";
            this.Text = "Agregar Sucursales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;
    }
}