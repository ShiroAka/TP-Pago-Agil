namespace PagoAgil.BillReturn
{
    partial class BillReturnView
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
            this._BillsToReturn = new System.Windows.Forms.DataGridView();
            this.BtnAddBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnReason = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._BillsToReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas a Devolver";
            // 
            // _BillsToReturn
            // 
            this._BillsToReturn.AllowUserToAddRows = false;
            this._BillsToReturn.AllowUserToDeleteRows = false;
            this._BillsToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._BillsToReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this._BillsToReturn.Location = new System.Drawing.Point(12, 37);
            this._BillsToReturn.Name = "_BillsToReturn";
            this._BillsToReturn.ReadOnly = true;
            this._BillsToReturn.Size = new System.Drawing.Size(502, 132);
            this._BillsToReturn.TabIndex = 1;
            // 
            // BtnAddBill
            // 
            this.BtnAddBill.Location = new System.Drawing.Point(419, 175);
            this.BtnAddBill.Name = "BtnAddBill";
            this.BtnAddBill.Size = new System.Drawing.Size(95, 23);
            this.BtnAddBill.TabIndex = 2;
            this.BtnAddBill.Text = "Agregar Factura";
            this.BtnAddBill.UseVisualStyleBackColor = true;
            this.BtnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Motivo: ";
            // 
            // ReturnReason
            // 
            this.ReturnReason.Location = new System.Drawing.Point(63, 207);
            this.ReturnReason.MaxLength = 255;
            this.ReturnReason.Name = "ReturnReason";
            this.ReturnReason.Size = new System.Drawing.Size(307, 20);
            this.ReturnReason.TabIndex = 4;
            this.ReturnReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(429, 260);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 5;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(15, 260);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BillReturnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 295);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.ReturnReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddBill);
            this.Controls.Add(this._BillsToReturn);
            this.Controls.Add(this.label1);
            this.Name = "BillReturnView";
            this.Text = "Devolver Facturas";
            ((System.ComponentModel.ISupportInitialize)(this._BillsToReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _BillsToReturn;
        private System.Windows.Forms.Button BtnAddBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReturnReason;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;
    }
}