namespace PagoAgil.Accountability
{
    partial class BillAccounting
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
            this.Enterprises = new System.Windows.Forms.ComboBox();
            this.BtnDoAccounting = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BillsQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CommissionPercentage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountedValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CommissionValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this._TotalAccountingValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.BillsList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa: ";
            // 
            // Enterprises
            // 
            this.Enterprises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Enterprises.FormattingEnabled = true;
            this.Enterprises.Location = new System.Drawing.Point(80, 26);
            this.Enterprises.Name = "Enterprises";
            this.Enterprises.Size = new System.Drawing.Size(130, 21);
            this.Enterprises.TabIndex = 1;
            this.Enterprises.SelectedIndexChanged += new System.EventHandler(this.Enterprises_SelectedIndexChanged);
            // 
            // BtnDoAccounting
            // 
            this.BtnDoAccounting.Location = new System.Drawing.Point(309, 401);
            this.BtnDoAccounting.Name = "BtnDoAccounting";
            this.BtnDoAccounting.Size = new System.Drawing.Size(99, 23);
            this.BtnDoAccounting.TabIndex = 4;
            this.BtnDoAccounting.Text = "Rendir Facturas";
            this.BtnDoAccounting.UseVisualStyleBackColor = true;
            this.BtnDoAccounting.Click += new System.EventHandler(this.BtnDoAccounting_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 401);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 5;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de facturas a rendir: ";
            // 
            // BillsQty
            // 
            this.BillsQty.Enabled = false;
            this.BillsQty.Location = new System.Drawing.Point(175, 74);
            this.BillsQty.Name = "BillsQty";
            this.BillsQty.ReadOnly = true;
            this.BillsQty.Size = new System.Drawing.Size(80, 20);
            this.BillsQty.TabIndex = 7;
            this.BillsQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de rendicion: ";
            // 
            // CommissionPercentage
            // 
            this.CommissionPercentage.Enabled = false;
            this.CommissionPercentage.Location = new System.Drawing.Point(175, 152);
            this.CommissionPercentage.Name = "CommissionPercentage";
            this.CommissionPercentage.ReadOnly = true;
            this.CommissionPercentage.Size = new System.Drawing.Size(80, 20);
            this.CommissionPercentage.TabIndex = 13;
            this.CommissionPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Porcentaje de comision: ";
            // 
            // AccountedValue
            // 
            this.AccountedValue.Enabled = false;
            this.AccountedValue.Location = new System.Drawing.Point(175, 204);
            this.AccountedValue.Name = "AccountedValue";
            this.AccountedValue.ReadOnly = true;
            this.AccountedValue.Size = new System.Drawing.Size(80, 20);
            this.AccountedValue.TabIndex = 11;
            this.AccountedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Importe de rendicion: ";
            // 
            // CommissionValue
            // 
            this.CommissionValue.Enabled = false;
            this.CommissionValue.Location = new System.Drawing.Point(175, 178);
            this.CommissionValue.Name = "CommissionValue";
            this.CommissionValue.ReadOnly = true;
            this.CommissionValue.Size = new System.Drawing.Size(80, 20);
            this.CommissionValue.TabIndex = 15;
            this.CommissionValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Importe de comision: ";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(252, 24);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(85, 23);
            this.BtnSelect.TabIndex = 18;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // _TotalAccountingValue
            // 
            this._TotalAccountingValue.Enabled = false;
            this._TotalAccountingValue.Location = new System.Drawing.Point(175, 126);
            this._TotalAccountingValue.Name = "_TotalAccountingValue";
            this._TotalAccountingValue.ReadOnly = true;
            this._TotalAccountingValue.Size = new System.Drawing.Size(80, 20);
            this._TotalAccountingValue.TabIndex = 17;
            this._TotalAccountingValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor total de pagos a rendir:";
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Location = new System.Drawing.Point(175, 100);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(80, 20);
            this.Date.TabIndex = 9;
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BillsList
            // 
            this.BillsList.AllowUserToAddRows = false;
            this.BillsList.AllowUserToDeleteRows = false;
            this.BillsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsList.Location = new System.Drawing.Point(12, 255);
            this.BillsList.Name = "BillsList";
            this.BillsList.ReadOnly = true;
            this.BillsList.Size = new System.Drawing.Size(396, 130);
            this.BillsList.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Facturas a rendir";
            // 
            // BillAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 436);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BillsList);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this._TotalAccountingValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommissionValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CommissionPercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AccountedValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BillsQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDoAccounting);
            this.Controls.Add(this.Enterprises);
            this.Controls.Add(this.label1);
            this.Name = "BillAccounting";
            this.Text = "Rendir Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.BillsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Enterprises;
        private System.Windows.Forms.Button BtnDoAccounting;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BillsQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CommissionPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccountedValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CommissionValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox _TotalAccountingValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.DataGridView BillsList;
        private System.Windows.Forms.Label label8;
    }
}