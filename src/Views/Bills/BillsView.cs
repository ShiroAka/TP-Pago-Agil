using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.SearchViews;
using PagoAgil.MiscMethods;
using PagoAgil.ViewModels;

namespace PagoAgil.Bills
{
    public partial class BillsView : Form, ClientSearchingForm
    {
        public Item_Factura CurrentBillItem { get; set; }
        private BindingList<Item_Factura> BillItems { get; set; }       //If I use a "List<T>", when using that list as the datagrid's datasource, the datagrid will 
                                                                        //not show changes to the list. To avoid that, I have to use a "BindingList<T>"
        private decimal CurrentTotalValue { get; set; }
        public Cliente CurrentClient { get; set; }
        private bool IsModifying;
        private decimal BillBeingModified;
        private BillsViewVM viewModel = new BillsViewVM();

        public BillsView()
        {
            InitializeComponent();
            this.CenterToScreen();

            IsModifying = false;
            SetFields();
            BillItems = new BindingList<Item_Factura>();
            BillItemsList.DataSource = BillItems;
            CurrentTotalValue = 0;
            FormatDataGrid();
            this.BtnDeleteItem.Enabled = false;
        }

        public BillsView(Factura bill)
        {
            InitializeComponent();

            IsModifying = true;
            BillBeingModified = bill.idFactura;
            SetFields();

            CurrentClient = viewModel.GetClient(bill.Cliente);
            this.Client.Text = CurrentClient.Nombre[0] + ". " + CurrentClient.Apellido;

            List<Empresa> enterpriseList = viewModel.GetEnterprises().ToList();

            //Finds the index of the enterprise with the id of the one referenced in the bill, and adds 1 to that number 
            //(because enterprise indexes in the comboBox start from 1)
            
            Enterprise.SelectedIndex = enterpriseList.FindIndex(0, x => x.idEmpresa == bill.Empresa) + 1;

            BillNbr.Text = bill.Nro_Factura.ToString();
            CreationDate.Value = bill.FechaAlta;
            ExpirationDate.Value = bill.FechaVenc;

            BillItems = new BindingList<Item_Factura>(viewModel.GetBillItems(bill.idFactura).ToList());

            BillItemsList.DataSource = BillItems;
            CurrentTotalValue = 0;

            foreach (Item_Factura item in BillItems)
            {
                CurrentTotalValue += item.Importe;
            }
            BillItemsTotal.Text = String.Format("{0:C2}", CurrentTotalValue);

            FormatDataGrid();            
        }

        #region Events
        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            FindClientsView view = new FindClientsView();

            this.Hide();
            var dialogResult = view.ShowDialog(this); //When the child form closes, the 'ShowDialog()' method returns a value
                                                      //If no assignation is made, this method continues with the following line after showing the child form

            //Without this, it will try to do the following after clicking the return button in the client search screen, and will throw a null pointer exception (CurrentClient will not be set)
            if (dialogResult == DialogResult.OK)
                this.Client.Text = CurrentClient.Nombre[0] + ". " + CurrentClient.Apellido;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            Bill_ItemsView view = new Bill_ItemsView();

            this.Hide();
            var dialogResult = view.ShowDialog(this);

            BillItems.Add(CurrentBillItem);
            CurrentTotalValue += CurrentBillItem.Importe;
            BillItemsTotal.Text = String.Format("{0:C2}", CurrentTotalValue);
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            Item_Factura selectedItem = (Item_Factura)BillItemsList.CurrentRow.DataBoundItem;

            CurrentTotalValue -= selectedItem.Importe;
            BillItems.Remove(selectedItem);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {  
            if(!IsModifying)
            {
                if (WrongOrEmptyFields() || BillIsInDatabase())
                    return;

                CreateNewBill();
            }
            else
            {
                if (WrongOrEmptyFields())
                    return;

                ModifyExistingBill();
            }

            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void Enterprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)this.Enterprise.SelectedValue == 0)
            {
                this.BtnAccept.Enabled = false;
            }
            else
            {
                this.BtnAccept.Enabled = true;
            }
        }

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

        private void BillItemsList_SelectionChanged(object sender, EventArgs e)
        {
            if (BillItemsList.SelectedRows.Count != 0)
                this.BtnDeleteItem.Enabled = true;
            else
                this.BtnDeleteItem.Enabled = false;
        }
        #endregion

        #region Methods
        private void CreateNewBill()
        {
            viewModel.CreateNewBill(CurrentClient.idCliente, Convert.ToDecimal(Enterprise.SelectedValue), this.CreationDate.Value, this.ExpirationDate.Value, 
                                    decimal.Parse(this.BillNbr.Text), CurrentTotalValue, BillItems.ToList());

            MessageBox.Show(this, "Factura creada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModifyExistingBill()
        {
            viewModel.ModifyExistingBill(BillBeingModified, CurrentClient.idCliente, Convert.ToDecimal(Enterprise.SelectedValue), this.CreationDate.Value, this.ExpirationDate.Value,
                                         this.CurrentTotalValue, decimal.Parse(this.BillNbr.Text), BillItems.ToList());

            MessageBox.Show(this, "Factura modificada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetFields()
        {
            IQueryable<Empresa> enterprises = viewModel.GetEnterprises();
            List<TextValuePair> comboBoxItems = new List<TextValuePair>();
            comboBoxItems.Add(new TextValuePair("SELECCIONAR", 0));

            foreach (Empresa enterprise in enterprises)
            {
                comboBoxItems.Add(new TextValuePair(enterprise.Nombre, (int)enterprise.idEmpresa));
            }

            Enterprise.DisplayMember = "Text";
            Enterprise.ValueMember = "Value";
            Enterprise.DataSource = comboBoxItems;
            BillItemsTotal.Text = ((decimal)0).ToString();
        }

        private bool WrongOrEmptyFields()
        {
            if (Validation.EmptyTextBox(Client))
            {
                MessageBox.Show(this, "Debe seleccionar un cliente con el buscador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (Validation.NonNumericTextBoxText(this.BillNbr).Count != 0)
            {
                MessageBox.Show(this, "El campo \"Nº Factura\" solo puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (Validation.EmptyTextBox(this.BillNbr))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if(this.CreationDate.Value.Equals(this.ExpirationDate.Value))
            {
                MessageBox.Show(this, "La fecha de alta no puede coincidir con la de vencimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //if (this.FechaAlta.Value > DateTime.Now)
            if(this.CreationDate.Value > Login.SystemDate)
            {
                MessageBox.Show(this, "La fecha de alta no puede ser mayor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //if (this.FechaVencimiento.Value < DateTime.Now)
            if(this.ExpirationDate.Value < Login.SystemDate)
            {
                MessageBox.Show(this, "La fecha de vencimiento no puede ser menor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (this.CreationDate.Value > this.ExpirationDate.Value)
            {
                MessageBox.Show(this, "La fecha de vencimiento no puede ser menor a la fecha de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (this.BillItems.Count == 0)
            {
                MessageBox.Show(this, "Debe agregar al menos un item a la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;            
        }

        private bool BillIsInDatabase()
        {
            decimal billId = decimal.Parse(this.BillNbr.Text);
            decimal enterpriseId = Convert.ToDecimal(this.Enterprise.SelectedValue);

            if (viewModel.BillExistsInDB(billId, enterpriseId))
            {
                MessageBox.Show(this, "Ya existe una factura con el mismo numero para la empresa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void FormatDataGrid()
        {
            BillItemsList.ClearSelection();
            BillItemsList.Columns["idItem"].Visible = false;
            BillItemsList.Columns["Factura"].Visible = false;
            BillItemsList.Columns["Factura1"].Visible = false;
        }
        #endregion       
    }
}
