
namespace PagoAgil.Bills
{
    partial class BillSearchView
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
            this.SearchMethod = new System.Windows.Forms.ComboBox();
            this.BillNbr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFindClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Enterprise = new System.Windows.Forms.ComboBox();
            this.Client = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de busqueda: ";
            // 
            // SearchMethod
            // 
            this.SearchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchMethod.FormattingEnabled = true;
            this.SearchMethod.Location = new System.Drawing.Point(128, 27);
            this.SearchMethod.Name = "SearchMethod";
            this.SearchMethod.Size = new System.Drawing.Size(121, 21);
            this.SearchMethod.TabIndex = 2;
            this.SearchMethod.SelectedIndexChanged += new System.EventHandler(this.SearchMethod_SelectedIndexChanged);
            // 
            // BillNbr
            // 
            this.BillNbr.Enabled = false;
            this.BillNbr.Location = new System.Drawing.Point(128, 65);
            this.BillNbr.MaxLength = 18;
            this.BillNbr.Name = "BillNbr";
            this.BillNbr.Size = new System.Drawing.Size(121, 20);
            this.BillNbr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº Factura: ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.MaximumSize = new System.Drawing.Size(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 2);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 2);
            this.label4.TabIndex = 6;
            // 
            // BtnFindClient
            // 
            this.BtnFindClient.Enabled = false;
            this.BtnFindClient.Location = new System.Drawing.Point(266, 126);
            this.BtnFindClient.Name = "BtnFindClient";
            this.BtnFindClient.Size = new System.Drawing.Size(85, 23);
            this.BtnFindClient.TabIndex = 7;
            this.BtnFindClient.Text = "Buscar Cliente";
            this.BtnFindClient.UseVisualStyleBackColor = true;
            this.BtnFindClient.Click += new System.EventHandler(this.BtnFindClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empresa: ";
            // 
            // Enterprise
            // 
            this.Enterprise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Enterprise.Enabled = false;
            this.Enterprise.FormattingEnabled = true;
            this.Enterprise.Location = new System.Drawing.Point(128, 101);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(121, 21);
            this.Enterprise.TabIndex = 9;
            // 
            // Client
            // 
            this.Client.Enabled = false;
            this.Client.Location = new System.Drawing.Point(128, 128);
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Size = new System.Drawing.Size(121, 20);
            this.Client.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cliente: ";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 156);
            this.label7.MaximumSize = new System.Drawing.Size(0, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 2);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Resultados de la busqueda";
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToAddRows = false;
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.CausesValidation = false;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Location = new System.Drawing.Point(12, 222);
            this.SearchResults.MultiSelect = false;
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.ReadOnly = true;
            this.SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResults.Size = new System.Drawing.Size(502, 209);
            this.SearchResults.TabIndex = 14;
            this.SearchResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SearchResults_CellFormatting);
            this.SearchResults.SelectionChanged += new System.EventHandler(this.SearchResults_SelectionChanged);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 454);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 15;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Enabled = false;
            this.BtnModify.Location = new System.Drawing.Point(429, 454);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 23);
            this.BtnModify.TabIndex = 16;
            this.BtnModify.Text = "Modificar";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(224, 454);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Dar de Baja";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchMethod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BillNbr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnFindClient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Client);
            this.groupBox1.Controls.Add(this.Enterprise);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(429, 176);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 23);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BillSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 489);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "BillSearchView";
            this.Text = "Buscar Facturas";
            this.Load += new System.EventHandler(this.BillSearchView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchMethod;
        private System.Windows.Forms.TextBox BillNbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFindClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Enterprise;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearch;
    }
}