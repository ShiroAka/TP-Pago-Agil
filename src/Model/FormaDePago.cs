//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PagoAgil.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormaDePago
    {
        public FormaDePago()
        {
            this.PagoDeFacturas = new HashSet<PagoDeFacturas>();
        }
    
        public decimal idFormaPago { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<PagoDeFacturas> PagoDeFacturas { get; set; }
    }
}