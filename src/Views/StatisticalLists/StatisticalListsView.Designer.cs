namespace PagoAgil.StatisticalLists
{
    partial class StatisticalListsView
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
            this.StatisticalListType = new System.Windows.Forms.ComboBox();
            this.Quarter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGetList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatisticalList = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticalList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Listado: ";
            // 
            // StatisticalListType
            // 
            this.StatisticalListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatisticalListType.FormattingEnabled = true;
            this.StatisticalListType.Location = new System.Drawing.Point(104, 26);
            this.StatisticalListType.Name = "StatisticalListType";
            this.StatisticalListType.Size = new System.Drawing.Size(283, 21);
            this.StatisticalListType.TabIndex = 1;
            // 
            // Quarter
            // 
            this.Quarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Quarter.FormattingEnabled = true;
            this.Quarter.Location = new System.Drawing.Point(104, 53);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(283, 21);
            this.Quarter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre:  ";
            // 
            // BtnGetList
            // 
            this.BtnGetList.Location = new System.Drawing.Point(291, 112);
            this.BtnGetList.Name = "BtnGetList";
            this.BtnGetList.Size = new System.Drawing.Size(95, 23);
            this.BtnGetList.TabIndex = 4;
            this.BtnGetList.Text = "Obtener Listado";
            this.BtnGetList.UseVisualStyleBackColor = true;
            this.BtnGetList.Click += new System.EventHandler(this.BtnGetList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado Estadistico";
            // 
            // StatisticalList
            // 
            this.StatisticalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticalList.Location = new System.Drawing.Point(20, 150);
            this.StatisticalList.Name = "StatisticalList";
            this.StatisticalList.Size = new System.Drawing.Size(366, 146);
            this.StatisticalList.TabIndex = 6;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(302, 303);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año:";
            // 
            // Year
            // 
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(104, 80);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(71, 21);
            this.Year.TabIndex = 9;
            // 
            // StatisticalListsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 336);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.StatisticalList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGetList);
            this.Controls.Add(this.Quarter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatisticalListType);
            this.Controls.Add(this.label1);
            this.Name = "StatisticalListsView";
            this.Text = "Listados Estadisticos";
            ((System.ComponentModel.ISupportInitialize)(this.StatisticalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatisticalListType;
        private System.Windows.Forms.ComboBox Quarter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGetList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView StatisticalList;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Year;
    }
}