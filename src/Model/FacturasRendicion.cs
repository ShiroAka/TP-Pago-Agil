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
    
    public partial class FacturasRendicion
    {
        public decimal idFacturaRendicion { get; set; }
        public decimal Factura { get; set; }
        public decimal Rendicion { get; set; }
    
        public virtual Factura Factura1 { get; set; }
        public virtual Rendicion Rendicion1 { get; set; }
    }
}
