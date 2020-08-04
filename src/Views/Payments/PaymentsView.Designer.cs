namespace PagoAgil.Payments
{
    partial class PaymentsView
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
            this.PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFindClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BillsList = new System.Windows.Forms.DataGridView();
            this.BtnAddBill = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.TextBox();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillsList)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentDate
            // 
            this.PaymentDate.Enabled = false;
            this.PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDate.Location = new System.Drawing.Point(115, 78);
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Size = new System.Drawing.Size(119, 20);
            this.PaymentDate.TabIndex = 2;
            this.PaymentDate.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Cobro: ";
            // 
            // Client
            // 
            this.Client.Enabled = false;
            this.Client.Location = new System.Drawing.Point(115, 26);
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Size = new System.Drawing.Size(119, 20);
            this.Client.TabIndex = 7;
            this.Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:  ";
            // 
            // BtnFindClient
            // 
            this.BtnFindClient.Location = new System.Drawing.Point(250, 26);
            this.BtnFindClient.Name = "BtnFindClient";
            this.BtnFindClient.Size = new System.Drawing.Size(85, 23);
            this.BtnFindClient.TabIndex = 8;
            this.BtnFindClient.Text = "Buscar Cliente";
            this.BtnFindClient.UseVisualStyleBackColor = true;
            this.BtnFindClient.Click += new System.EventHandler(this.BtnFindClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sucursal: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Facturas del Pago";
            // 
            // BillsList
            // 
            this.BillsList.AllowUserToAddRows = false;
            this.BillsList.AllowUserToDeleteRows = false;
            this.BillsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsList.Location = new System.Drawing.Point(15, 157);
            this.BillsList.Name = "BillsList";
            this.BillsList.ReadOnly = true;
            this.BillsList.Size = new System.Drawing.Size(374, 115);
            this.BillsList.TabIndex = 12;
            // 
            // BtnAddBill
            // 
            this.BtnAddBill.Location = new System.Drawing.Point(294, 278);
            this.BtnAddBill.Name = "BtnAddBill";
            this.BtnAddBill.Size = new System.Drawing.Size(95, 23);
            this.BtnAddBill.TabIndex = 13;
            this.BtnAddBill.Text = "Agregar Factura";
            this.BtnAddBill.UseVisualStyleBackColor = true;
            this.BtnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 334);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 14;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(304, 334);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 15;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Metodo de Pago: ";
            // 
            // Branch
            // 
            this.Branch.Enabled = false;
            this.Branch.Location = new System.Drawing.Point(115, 52);
            this.Branch.MaxLength = 255;
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Size = new System.Drawing.Size(119, 20);
            this.Branch.TabIndex = 18;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Location = new System.Drawing.Point(115, 105);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(119, 21);
            this.PaymentMethod.TabIndex = 19;
            // 
            // RegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 369);
            this.ControlBox = false;
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAddBill);
            this.Controls.Add(this.BillsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnFindClient);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentDate);
            this.Name = "RegistroPagos";
            this.Text = "Registrar Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.BillsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PaymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFindClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BillsList;
        private System.Windows.Forms.Button BtnAddBill;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Branch;
        private System.Windows.Forms.ComboBox PaymentMethod;
    }
}