﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TLAPIANIEntities : DbContext
    {
        public TLAPIANIEntities()
            : base("name=TLAPIANIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DISPOSITIVO> DISPOSITIVOes { get; set; }
        public virtual DbSet<HORARIO> HORARIOs { get; set; }
        public virtual DbSet<LECTOR> LECTORs { get; set; }
        public virtual DbSet<REGISTRO> REGISTROes { get; set; }
        public virtual DbSet<RELACION_SUJETO_USUARIO> RELACION_SUJETO_USUARIO { get; set; }
        public virtual DbSet<SUJETO> SUJETOes { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
    }
}
