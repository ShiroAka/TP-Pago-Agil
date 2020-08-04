using System.Windows.Forms;

namespace PagoAgil.Clients
{
    partial class ClientsView
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
            this.BtnAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZipCode = new System.Windows.Forms.NumericUpDown();
            this.Floor = new System.Windows.Forms.NumericUpDown();
            this.City = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Apartment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this._Name = new System.Windows.Forms.TextBox();
            this.Identification = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(418, 225);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(73, 52);
            this.LastName.MaxLength = 255;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(170, 20);
            this.LastName.TabIndex = 4;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(87, 21);
            this.Street.MaxLength = 150;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(170, 20);
            this.Street.TabIndex = 5;
            this.Street.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail:";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(73, 79);
            this.Mail.MaxLength = 255;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(170, 20);
            this.Mail.TabIndex = 7;
            this.Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DNI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Codigo Postal:";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(402, 26);
            this.Phone.MaxLength = 50;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(101, 20);
            this.Phone.TabIndex = 10;
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefono:";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 225);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(85, 23);
            this.BtnReturn.TabIndex = 17;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZipCode);
            this.groupBox1.Controls.Add(this.Floor);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Apartment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Street);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            // 
            // ZipCode
            // 
            this.ZipCode.Location = new System.Drawing.Point(87, 74);
            this.ZipCode.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(81, 20);
            this.ZipCode.TabIndex = 14;
            this.ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Floor
            // 
            this.Floor.Location = new System.Drawing.Point(370, 24);
            this.Floor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(53, 20);
            this.Floor.TabIndex = 13;
            this.Floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(87, 47);
            this.City.MaxLength = 50;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(144, 20);
            this.City.TabIndex = 11;
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Localidad:";
            // 
            // Apartment
            // 
            this.Apartment.Location = new System.Drawing.Point(370, 47);
            this.Apartment.MaxLength = 3;
            this.Apartment.Name = "Apartment";
            this.Apartment.Size = new System.Drawing.Size(83, 20);
            this.Apartment.TabIndex = 9;
            this.Apartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Departamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Piso:";
            // 
            // BirthDate
            // 
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(402, 79);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(101, 20);
            this.BirthDate.TabIndex = 19;
            // 
            // _Name
            // 
            this._Name.BackColor = System.Drawing.Color.White;
            this._Name.Location = new System.Drawing.Point(73, 26);
            this._Name.MaxLength = 255;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(170, 20);
            this._Name.TabIndex = 20;
            this._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Identification
            // 
            this.Identification.Location = new System.Drawing.Point(402, 52);
            this.Identification.MaxLength = 18;
            this.Identification.Name = "Identification";
            this.Identification.Size = new System.Drawing.Size(101, 20);
            this.Identification.TabIndex = 13;
            this.Identification.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.ControlBox = false;
            this.Controls.Add(this._Name);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Identification);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.label1);
            this.Name = "ClientsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Clientes";
            this.Shown += new System.EventHandler(this.AltaClientes_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Floor;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Apartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.NumericUpDown ZipCode;
        private System.Windows.Forms.TextBox _Name;
        private TextBox Identification;
    }
}