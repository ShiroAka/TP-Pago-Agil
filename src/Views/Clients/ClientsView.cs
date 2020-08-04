using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.MiscMethods;
using PagoAgil.Model;
using PagoAgil.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace PagoAgil.Clients
{
    public partial class ClientsView : Form
    {
        private bool IsModifying;
        private decimal CurrentClientId;
        private bool IsClientDataWrong;
        private ClientsViewVM viewModel = new ClientsViewVM();

        public ClientsView()
        {
            InitializeComponent();
            this.CenterToScreen();
            IsModifying = false;
        }

        public ClientsView(Cliente client)
        {
            InitializeComponent();
            this.CenterToScreen();

            IsModifying = true;
            CurrentClientId = client.idCliente;

            this.Text = "Modificar Cliente";
            this._Name.Text = client.Nombre;
            this.LastName.Text = client.Apellido;
            this.Mail.Text = client.Mail;
            this.Identification.Text = client.DNI.ToString();
            this.Phone.Text = client.Telefono;
            this.BirthDate.Value = client.Fecha_Nac;
            this.ZipCode.Value = decimal.Parse(client.Cod_Postal);

            DisassembleAddress(client.Direccion);

            IsClientDataWrong = client.DatosErroneos;            
        }

        #region Events
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (IsModifying)
            {
                MessageBox.Show(this, "El cliente no se ha modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (WrongOrEmptyFields() || WrongOrUsedEmail())
                return;           

            if (IsModifying)
            {
                ModifyExistingClient();                
            }
            else
            {
                CreateNewClient();
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private bool WrongOrEmptyFields()
        {
            List<Control> wrongControls = Validation.EmptyTextBoxes(this._Name, this.LastName, this.Mail, this.Phone, this.Identification,
                                                                            this.Street, this.City);

            if (wrongControls.Count != 0)
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            wrongControls = Validation.ZeroedNumericUpDown(this.ZipCode);

            if (wrongControls.Count != 0)
            {
                MessageBox.Show(this, "El campo \"Codigo Postal\" debe contener un valor distinto de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            int n;

            if (!int.TryParse(this.Identification.Text, out n))
            {
                MessageBox.Show(this, "El campo \"DNI\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            //The following validation is opcional, I put it just in case

            //if ((DateTime.Now.Year - FechaNacimiento.Value.Year) < 18)
            if ((Login.SystemDate.Year - BirthDate.Value.Year) < 18)
            {
                MessageBox.Show(this, "El cliente no puede ser menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            PhoneAttribute phone = new PhoneAttribute();
            if (!phone.IsValid(this.Phone.Text))
            {
                MessageBox.Show(this, "El formato del telefono especificado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private bool WrongOrUsedEmail()
        {
            EmailAddressAttribute email = new EmailAddressAttribute();

            if (!email.IsValid(this.Mail.Text))
            {
                MessageBox.Show(this, "El formato del mail especificado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            
            if (IsModifying)
            {
                if(viewModel.IsMailAlreadyInUse(this.Mail.Text, CurrentClientId))
                {
                    MessageBox.Show(this, "El mail especificado ya esta siendo usado por otro cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            else if (viewModel.IsMailAlreadyInUse(this.Mail.Text))
            {
                MessageBox.Show(this, "El mail especificado ya esta siendo usado por otro cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void DisassembleAddress(String address)
        {
            List<String> disassembledAddress = address.Split(',').ToList();

            //This is ugly, but I had no other way to do it

            if (disassembledAddress.Count == 1)
            {
                this.Street.Text = disassembledAddress[0];
            }
            else
            {
                this.Street.Text = disassembledAddress[0];
                this.Floor.Value = int.Parse(disassembledAddress[1]);

                if (disassembledAddress.Count == 3) //Street, Floor and City (No apartment number)
                {
                    this.City.Text = disassembledAddress[2];
                    this.Apartment.Text = String.Empty;
                }
                else if(disassembledAddress.Count == 4)
                {
                    this.Apartment.Text = disassembledAddress[2];
                    this.City.Text = disassembledAddress[3];
                }
            }
        }

        private void CreateNewClient()
        {
            viewModel.CreateNewClient(this._Name.Text, this.LastName.Text, this.Mail.Text, this.Phone.Text, decimal.Parse(this.Identification.Text), this.Street.Text, this.Floor.Value.ToString(),
                                      this.Apartment.Text, this.City.Text, this.ZipCode.Value.ToString(), this.BirthDate.Value);

            MessageBox.Show(this, "Cliente agregado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModifyExistingClient()
        {
            viewModel.ModifyExistingClient(CurrentClientId, this._Name.Text, this.LastName.Text, this.Mail.Text, this.Phone.Text, decimal.Parse(this.Identification.Text), this.Street.Text, 
                                           this.Floor.Value.ToString(), this.Apartment.Text, this.City.Text, this.ZipCode.Value.ToString(), this.BirthDate.Value);

            MessageBox.Show(this, "Cliente modificado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AltaClientes_Shown(object sender, EventArgs e)
        {
            if (IsClientDataWrong)
            {
                MessageBox.Show(this, "Algunos datos de este cliente son incorrectos\nCorrijalos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
