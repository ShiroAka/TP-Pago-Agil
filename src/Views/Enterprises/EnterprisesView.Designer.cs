using System;
using System.Drawing;
using System.Windows.Forms;


namespace PagoAgil.Enterprises
{
    partial class EnterprisesView
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
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this._Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.ComboBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "CUIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Direccion:";
            // 
            // CUIT
            // 
            this.CUIT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CUIT.Location = new System.Drawing.Point(73, 78);
            this.CUIT.MaxLength = 11;
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(170, 20);
            this.CUIT.TabIndex = 13;
            this.CUIT.Text = "11 Digitos sin Guiones";
            this.CUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CUIT.Enter += new System.EventHandler(this.CUIT_Enter);
            this.CUIT.Leave += new System.EventHandler(this.CUIT_Leave);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(73, 52);
            this.Address.MaxLength = 255;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(170, 20);
            this.Address.TabIndex = 12;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(73, 26);
            this._Name.MaxLength = 255;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(170, 20);
            this._Name.TabIndex = 10;
            this._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rubro: ";
            // 
            // Area
            // 
            this.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area.FormattingEnabled = true;
            this.Area.Location = new System.Drawing.Point(73, 104);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(121, 21);
            this.Area.TabIndex = 18;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(152, 147);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 19;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(35, 147);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // EnterprisesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CUIT);
            this.Controls.Add(this.Address);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.label1);
            this.Name = "EnterprisesView";
            this.Text = "Agregar Empresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Area;       
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;

        private void CUIT_Leave(object sender, EventArgs e)
        {
            if (this.CUIT.Text.Length == 0)
            {
                this.CUIT.Text = "11 Digitos sin Guiones";
                this.CUIT.ForeColor = SystemColors.GrayText;
            }
        }

        private void CUIT_Enter(object sender, EventArgs e)
        {
            if (this.CUIT.Text == "11 Digitos sin Guiones")
            {
                this.CUIT.Text = "";
                this.CUIT.ForeColor = SystemColors.WindowText;
            }
        }
    }
}