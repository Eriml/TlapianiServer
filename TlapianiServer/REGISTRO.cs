//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TlapianiServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISTRO
    {
        public int id { get; set; }
        public Nullable<int> Sujeto { get; set; }
        public Nullable<int> Dispositivo { get; set; }
        public Nullable<int> Lector { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public string Tipo { get; set; }
    
        public virtual DISPOSITIVO DISPOSITIVO1 { get; set; }
        public virtual LECTOR LECTOR1 { get; set; }
        public virtual SUJETO SUJETO1 { get; set; }
    }
}
