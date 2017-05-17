using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tlapiani.Models;

namespace Tlapiani
{
    public class ControladorDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ERIML\SQLEXPRESS;Database=TLAPIANI;Trusted_Connection=True");
        }

        public ControladorDB(DbContextOptions<ControladorDB> options)
            : base(options)
         { }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Sujeto> Sujetos { get; set; }
        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<RelacionSujetoUsuario> RelacionSU { get; set; }
        public virtual DbSet<Lector> Lectores { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }

        public virtual ObjectResult<GetUsuariosById_Result> GetUsuariosById(Nullable<T> usuarios)
        {
        
}

    }
}
