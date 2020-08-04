using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Model;

namespace PagoAgil.MiscMethods
{
    public class Validation
    {
        public static List<Control> EmptyTextBoxes(params TextBox[] textBoxes)
        {
            List<Control> emptyTextBoxes = new List<Control>();

            foreach (TextBox textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text))
                {
                    emptyTextBoxes.Add(textBox);
                }
            }

            return emptyTextBoxes;
        }

        public static bool EmptyTextBox(TextBox textBox)
        {
            return (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text));            
        }

        public static List<Control> NonNumericTextBoxText(params TextBox[] textBoxes)
        {
            List<Control> nonNumericTextBoxes = new List<Control>();

            foreach (TextBox textBox in textBoxes)
            {
                int n;

                if (!int.TryParse(textBox.Text, out n))
                {
                    nonNumericTextBoxes.Add(textBox);
                }
            }

            return nonNumericTextBoxes;
        }

        public static List<Control> NotSelectedComboBox(params ComboBox[] comboBoxes)
        {
            List<Control> notSelectedComboBoxes = new List<Control>();

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (((TextValuePair)comboBox.SelectedItem).Value == 0)  //Para que esto funcione, hay que setear un comboBox para que contenga elementos de la clase 'TextValuePair', y setear las propiedades del comboBox --> DisplayMember = "Text"; ValueMember = "Value"  
                {
                    notSelectedComboBoxes.Add(comboBox);
                }
            }

            return notSelectedComboBoxes;
        }

        public static List<Control> ZeroedNumericUpDown(params NumericUpDown[] numericUpDowns)
        {
            List<Control> zeroedNumericUpDowns = new List<Control>();

            foreach (NumericUpDown control in numericUpDowns)
            {
                if (control.Value == 0)
                {
                    zeroedNumericUpDowns.Add(control);
                }
            }

            return zeroedNumericUpDowns;
        }
    }
}