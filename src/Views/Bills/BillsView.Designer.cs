namespace PagoAgil.Bills
{
    partial class BillsView
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
            this.Client = new System.Windows.Forms.TextBox();
            this.BtnFindClient = new System.Windows.Forms.Button();
            this.Enterprise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BillNbr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BillItemsList = new System.Windows.Forms.DataGridView();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BillItemsTotal = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente: ";
            // 
            // Client
            // 
            this.Client.Enabled = false;
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Client.Location = new System.Drawing.Point(89, 26);
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Size = new System.Drawing.Size(150, 20);
            this.Client.TabIndex = 1;
            this.Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnFindClient
            // 
            this.BtnFindClient.Location = new System.Drawing.Point(249, 24);
            this.BtnFindClient.Name = "BtnFindClient";
            this.BtnFindClient.Size = new System.Drawing.Size(85, 23);
            this.BtnFindClient.TabIndex = 2;
            this.BtnFindClient.Text = "Buscar Cliente";
            this.BtnFindClient.UseVisualStyleBackColor = true;
            this.BtnFindClient.Click += new System.EventHandler(this.BtnFindClient_Click);
            // 
            // Enterprise
            // 
            this.Enterprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Enterprise.FormattingEnabled = true;
            this.Enterprise.Location = new System.Drawing.Point(89, 52);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(150, 21);
            this.Enterprise.TabIndex = 3;
            this.Enterprise.SelectedIndexChanged += new System.EventHandler(this.Enterprise_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empresa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº Factura: ";
            // 
            // BillNbr
            // 
            this.BillNbr.Location = new System.Drawing.Point(89, 79);
            this.BillNbr.MaxLength = 18;
            this.BillNbr.Name = "BillNbr";
            this.BillNbr.Size = new System.Drawing.Size(150, 20);
            this.BillNbr.TabIndex = 6;
            this.BillNbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Alta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Venc: ";
            // 
            // CreationDate
            // 
            this.CreationDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDate.Location = new System.Drawing.Point(89, 105);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(150, 20);
            this.CreationDate.TabIndex = 11;
            this.CreationDate.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationDate.Location = new System.Drawing.Point(89, 132);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(150, 20);
            this.ExpirationDate.TabIndex = 12;
            this.ExpirationDate.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Items de la factura";
            // 
            // BillItemsList
            // 
            this.BillItemsList.AllowUserToAddRows = false;
            this.BillItemsList.AllowUserToDeleteRows = false;
            this.BillItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillItemsList.Location = new System.Drawing.Point(12, 206);
            this.BillItemsList.Name = "BillItemsList";
            this.BillItemsList.ReadOnly = true;
            this.BillItemsList.Size = new System.Drawing.Size(323, 88);
            this.BillItemsList.TabIndex = 14;
            this.BillItemsList.SelectionChanged += new System.EventHandler(this.BillItemsList_SelectionChanged);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Location = new System.Drawing.Point(159, 300);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(85, 23);
            this.BtnAddItem.TabIndex = 15;
            this.BtnAddItem.Text = "Agregar Item";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total: ";
            // 
            // BillItemsTotal
            // 
            this.BillItemsTotal.Enabled = false;
            this.BillItemsTotal.Location = new System.Drawing.Point(55, 300);
            this.BillItemsTotal.Name = "BillItemsTotal";
            this.BillItemsTotal.ReadOnly = true;
            this.BillItemsTotal.Size = new System.Drawing.Size(77, 20);
            this.BillItemsTotal.TabIndex = 17;
            this.BillItemsTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(250, 354);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 18;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(22, 354);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 19;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Location = new System.Drawing.Point(250, 300);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteItem.TabIndex = 20;
            this.BtnDeleteItem.Text = "Eliminar Item";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // AltaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 389);
            this.ControlBox = false;
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BillItemsTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.BillItemsList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BillNbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enterprise);
            this.Controls.Add(this.BtnFindClient);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label1);
            this.Name = "AltaFacturas";
            this.Text = "Agregar Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.BillItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Button BtnFindClient;
        private System.Windows.Forms.ComboBox Enterprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BillNbr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ExpirationDate;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BillItemsList;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BillItemsTotal;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnDeleteItem;
    }
}