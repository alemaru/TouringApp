//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouringApp.Models.TO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cartilla
    {
        public int CartillaID { get; set; }
        public int UsuarioID { get; set; }
        public Nullable<int> Ex_escrito { get; set; }
        public Nullable<int> Ex_practico { get; set; }
        public Nullable<bool> Ex_medico { get; set; }
        public string Comentario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
