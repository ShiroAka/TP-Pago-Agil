using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Model
{
    class TextValuePair //This is used to set a Text-Value Pair for the comboboxes, in order to assign a value to the combobox text so as not to search values by text
    {
        public string Text {get; set;}
        public int Value { get; set; }

        public TextValuePair(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }
}
