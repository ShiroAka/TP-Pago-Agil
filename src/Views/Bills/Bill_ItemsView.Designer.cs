namespace PagoAgil.Bills
{
    partial class Bill_ItemsView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._Name = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.Value = new System.Windows.Forms.NumericUpDown();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto: ";
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(76, 26);
            this._Name.MaxLength = 255;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(125, 20);
            this._Name.TabIndex = 3;
            this._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(76, 52);
            this.Quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(70, 20);
            this.Quantity.TabIndex = 4;
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value
            // 
            this.Value.DecimalPlaces = 2;
            this.Value.Location = new System.Drawing.Point(76, 79);
            this.Value.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(70, 20);
            this.Value.TabIndex = 5;
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(185, 129);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(18, 129);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // bill_ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 164);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill_ItemsView";
            this.Text = "Item de Factura";
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.NumericUpDown Value;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;
    }
}