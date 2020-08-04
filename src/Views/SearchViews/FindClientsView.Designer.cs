namespace PagoAgil.SearchViews
{
    partial class FindClientsView
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientIdentification = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Enabled = false;
            this.BtnSelect.Location = new System.Drawing.Point(359, 352);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(85, 23);
            this.BtnSelect.TabIndex = 15;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 352);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 17;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ClientLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClientIdentification);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 121);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(69, 30);
            this.ClientName.MaxLength = 255;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(170, 20);
            this.ClientName.TabIndex = 6;
            this.ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido:";
            // 
            // ClientLastName
            // 
            this.ClientLastName.Location = new System.Drawing.Point(69, 56);
            this.ClientLastName.MaxLength = 255;
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.Size = new System.Drawing.Size(170, 20);
            this.ClientLastName.TabIndex = 8;
            this.ClientLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "DNI:";
            // 
            // ClientIdentification
            // 
            this.ClientIdentification.Location = new System.Drawing.Point(69, 82);
            this.ClientIdentification.MaxLength = 18;
            this.ClientIdentification.Name = "ClientIdentification";
            this.ClientIdentification.Size = new System.Drawing.Size(117, 20);
            this.ClientIdentification.TabIndex = 10;
            this.ClientIdentification.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(359, 139);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 23);
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToAddRows = false;
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.AllowUserToOrderColumns = true;
            this.SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SearchResults.CausesValidation = false;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Location = new System.Drawing.Point(12, 186);
            this.SearchResults.MultiSelect = false;
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.ReadOnly = true;
            this.SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResults.Size = new System.Drawing.Size(432, 146);
            this.SearchResults.TabIndex = 20;
            this.SearchResults.SelectionChanged += new System.EventHandler(this.SearchResults_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resultados de la busqueda";
            // 
            // ClientSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 387);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSelect);
            this.Name = "ClientSearchView";
            this.Text = "Buscar Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClientLastName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientIdentification;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Label label2;


    }
}