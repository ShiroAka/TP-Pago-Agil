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
    
    public partial class RolesUsuario
    {
        public decimal idRolUsuario { get; set; }
        public decimal Usuario { get; set; }
        public decimal Rol { get; set; }
    
        public virtual Rol Rol1 { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}