using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PagoAgil.Model;
using PagoAgil.ViewModels;

namespace PagoAgil.StatisticalLists
{
    public partial class StatisticalListsView : Form
    {
        private decimal _Year;
        private decimal[] _Quarter = new decimal[3];
        private decimal StatisticalListTypeValue;
        private bool ListWasModified = false;
        private bool DataWasInserted = false;
        private StatisticalListsViewVM viewModel = new StatisticalListsViewVM();


        public StatisticalListsView()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormatControls();
        }

        #region Events
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }

        private void BtnGetList_Click(object sender, EventArgs e)
        {
            _Year = Convert.ToDecimal(this.Year.SelectedItem);
            if (Quarter.SelectedIndex == 0) { _Quarter[0] = 1; _Quarter[1] = 2; _Quarter[2] = 3; }
            if (Quarter.SelectedIndex == 1) { _Quarter[0] = 4; _Quarter[1] = 5; _Quarter[2] = 6; }
            if (Quarter.SelectedIndex == 2) { _Quarter[0] = 7; _Quarter[1] = 8; _Quarter[2] = 9; }
            if (Quarter.SelectedIndex == 3) {_Quarter[0] = 10; _Quarter[1] = 11; _Quarter[2] = 12;}

            StatisticalListTypeValue = this.StatisticalListType.SelectedIndex;

            this.GetStatisticalList();
        }
        #endregion

        #region Methods
        private void GetStatisticalList()
        {
            decimal startMonth = _Quarter[0];
            decimal endMonth = _Quarter[2];

            #region Percentage of bills accounted by each enterprise
            if (StatisticalListTypeValue == 0) 
            {
                if (DataWasInserted)
                {
                    this.ClearStatisticalList();
                    ListWasModified = false;
                }
                if (!ListWasModified)
                {
                    DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(column1);
                    column1.HeaderText = "NOMBRE";
                    DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(column2);
                    column2.HeaderText = "FACTURAS COBRADAS (%)";
                    for (int i = 0; i < 5; i++) { StatisticalList.Rows.Add(); StatisticalList.Rows[i].HeaderCell.Value = Convert.ToString(i + 1); }
                    ListWasModified = true;
                }
                var enterprises2 = viewModel.GetPercentageOfBillsAccountedByEnterprise(_Year, startMonth, endMonth);
                var enterprisesList2 = enterprises2.ToList();
                decimal enterpriseId2;

                if (enterprisesList2.Count == 0)
                {
                    MessageBox.Show(this, "Ninguna empresa tuvo facturas cobradas en el trimestre y anio seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                    return;
                }

                try
                {
                    for (int i = 0; i < Math.Min(enterprisesList2.Count, 5); i++)
                    {
                        enterpriseId2 = ((dynamic)enterprisesList2[i]).EnterpriseId;        //As the enterprisesList2 has anonymous objects declared as 'object' (there is no way for the method that 
                                                                                            //gets the values to return an anonymous objects list, so it returns an 'object' list), if not using the 'dynamic' keyword, the 
                                                                                            //list element's property will never be recognized; if the property is not correct at runtime, this will throw an exception
                                                                                            //This is to avoid creating a new class for this specific object
                        Empresa ent = viewModel.GetEnterpriseById(enterpriseId2);
                        object[] asd = { ent.Nombre, Math.Round(((dynamic)enterprisesList2[i]).Percentage, 2)  };
                        for (int k = 0; k < 2; k++)
                        {
                            StatisticalList.Rows[i].Cells[k].Value = asd[k];
                        }
                    }
                    StatisticalList.Sort(StatisticalList.Columns[1], ListSortDirection.Descending);
                    DataWasInserted = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(this, "No hay informacion para el trimestre y seleccionado", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                }
            }
            #endregion

            #region Enterprises which sold the most
            if (StatisticalListTypeValue == 1)
            {
                if (DataWasInserted)
                {
                    this.ClearStatisticalList();
                    ListWasModified = false;
                }
                if (!ListWasModified)
                {
                    DataGridViewTextBoxColumn dgvc1 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc1);
                    dgvc1.HeaderText = "NOMBRE";
                    DataGridViewTextBoxColumn dgvc2 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc2);
                    dgvc2.HeaderText = "MONTO VENDIDO";
                    for (int i = 0; i < 5; i++) { StatisticalList.Rows.Add(); StatisticalList.Rows[i].HeaderCell.Value = Convert.ToString(i + 1); }
                    ListWasModified = true;
                }

                var enterprises = viewModel.GetEnterprisesWhichSoldTheMost(_Year, startMonth, endMonth);
                var enterprisesList = enterprises.ToList();
                decimal enterpriseId;

                if (enterprisesList.Count == 0)
                {
                    MessageBox.Show(this, "Ninguna empresa tuvo ventas en el trimestre y anio seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                    return;
                }
                
                try
                {
                    for (int i = 0; i < Math.Min(enterprisesList.Count, 5); i++)
                    {
                        enterpriseId = ((dynamic)enterprisesList[i]).EnterpriseId;
                        Empresa ent = viewModel.GetEnterpriseById(enterpriseId);
                        object[] asd = { ent.Nombre, ((dynamic)enterprisesList[i]).EnterpriseTotalAcountedValue };
                        for (int k = 0; k < 2; k++)
                        {
                            StatisticalList.Rows[i].Cells[k].Value = asd[k];
                        }
                    }
                    StatisticalList.Sort(StatisticalList.Columns[1], ListSortDirection.Descending);
                    DataWasInserted = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(this, "No hay informacion para el trimestre y seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                }
            }
            #endregion 

            #region Clients which made the most payments
            if (StatisticalListTypeValue == 2)
            {
                if (DataWasInserted)
                {
                    this.ClearStatisticalList();
                    ListWasModified = false;
                }
                if (!ListWasModified)
                {
                    DataGridViewTextBoxColumn dgvc1 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc1);
                    dgvc1.HeaderText = "NOMBRE";
                    DataGridViewTextBoxColumn dgvc2 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc2);
                    dgvc2.HeaderText = "APELLIDO";
                    DataGridViewTextBoxColumn dgvc3 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc3);
                    dgvc3.HeaderText = "MONTO PAGADO";
                    for (int i = 0; i < 5; i++) { StatisticalList.Rows.Add(); StatisticalList.Rows[i].HeaderCell.Value = Convert.ToString(i + 1); }
                    ListWasModified = true;
                }

                var client = viewModel.GetClientsWhichPayedTheMost(_Year, startMonth, endMonth);
                var clientsList = client.ToList();
                decimal clientId;

                if (clientsList.Count == 0)
                {
                    MessageBox.Show(this, "Ningun cliente realizo pagos en el trimestre y anio seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                    return;
                }
                try
                {
                    for (int i = 0; i < Math.Min(clientsList.Count, 5); i++)
                    {
                        clientId = ((dynamic)clientsList[i]).ClientId;
                        Cliente cli = viewModel.GetClientById(clientId); ;
                        object[] asd = { cli.Nombre, cli.Apellido, ((dynamic)clientsList[i]).ClientTotalPayments };
                        for (int k = 0; k < 3;k++)
                        {
                            StatisticalList.Rows[i].Cells[k].Value = asd[k];
                        }
                    }
                    StatisticalList.Sort(StatisticalList.Columns[2], ListSortDirection.Descending);
                    DataWasInserted = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(this, "No hay informacion para el trimestre y seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                }
            }
            #endregion 

            #region Clients with highest percentage of payed bills
            if (StatisticalListTypeValue == 3)
            {
                if (DataWasInserted)
                {
                    this.ClearStatisticalList();
                    ListWasModified = false;
                }
                if (!ListWasModified)
                {
                    DataGridViewTextBoxColumn dgvc1 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc1);
                    dgvc1.HeaderText = "NOMBRE";
                    DataGridViewTextBoxColumn dgvc2 = new DataGridViewTextBoxColumn(); StatisticalList.Columns.Add(dgvc2);
                    dgvc2.HeaderText = "FACTURAS PAGADAS (%)";
                    for (int i = 0; i < 5; i++) { StatisticalList.Rows.Add(); StatisticalList.Rows[i].HeaderCell.Value = Convert.ToString(i + 1); }
                    ListWasModified = true;
                }
                var client = viewModel.GetClientsWithHighestPercentageOfPayedBills(_Year, startMonth, endMonth);
                var clientsList = client.ToList();
                decimal clientId;

                if (clientsList.Count == 0)
                {
                    MessageBox.Show(this, "Ninguna empresa tuvo facturas cobradas en el trimestre y anio seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                    return;
                }

                try
                {
                    for (int i = 0; i < Math.Min(clientsList.Count,5); i++)
                    {
                        clientId = ((dynamic)clientsList[i]).ClientId;
                        Cliente cli = viewModel.GetClientById(clientId);
                        object[] asd = { cli.Nombre, Math.Round(((dynamic)clientsList[i]).Percentage, 2) };
                        for (int k = 0; k < 2; k++)
                        {
                            StatisticalList.Rows[i].Cells[k].Value = asd[k];
                        }
                    }
                    StatisticalList.Sort(StatisticalList.Columns[1], ListSortDirection.Descending);
                    DataWasInserted = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(this, "No hay informacion para el trimestre y seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataWasInserted = true;
                }

            }
            #endregion
        }

        private void FormatControls()
        {
            string[] StatisticalListTypesArray = {"Porcentaje de facturas cobradas por empresa", "Empresas con mayor monto vendido", "Clientes con mas pagos",
                                                  "Clientes con mayor porcentaje de facturas pagadas" };
            this.StatisticalListType.Items.AddRange(StatisticalListTypesArray);

            string[] quartersList = {"1 - 1 de Enero al 31 de Marzo", "2 - 1 de Abril al 30 de Junio",
                                  "3 - 1 de Julio al 30 de Septiembre", "4 - 1 de Octubre al 31 de Diciembre"};
            this.Quarter.Items.AddRange(quartersList);

            string[] yearsList = { "2016", "2017" };
            this.Year.Items.AddRange(yearsList);
        }

        private void ClearStatisticalList()
        {
            for (int i = 0; i < StatisticalList.ColumnCount +2; i++)
                StatisticalList.Columns.RemoveAt(0);
        }
        #endregion
    }
}
