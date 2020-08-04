using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Model;

namespace PagoAgil.ViewModels
{
    public class Bill_ItemsViewVM
    {
        public Bill_ItemsViewVM()
        { }

        public Item_Factura CreateNewItem(string itemName, decimal itemQuantity, decimal totalValue)
        {
            Item_Factura item = new Item_Factura();
            item.Nombre = itemName;
            item.Cantidad = itemQuantity;
            item.Importe = totalValue;

            return item;
        }
    }
}
