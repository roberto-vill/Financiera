﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Financiera.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinancieraEntities : DbContext
    {
        public FinancieraEntities()
            : base("name=FinancieraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Entidades> Entidades { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<modulo> modulo { get; set; }
        public virtual DbSet<Observaciones> Observaciones { get; set; }
        public virtual DbSet<operaciones> operaciones { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_operacion> rol_operacion { get; set; }
        public virtual DbSet<SolicitudBancos> SolicitudBancos { get; set; }
        public virtual DbSet<Solicitudes> Solicitudes { get; set; }
        public virtual DbSet<TiposObservaciones> TiposObservaciones { get; set; }
        public virtual DbSet<TiposRechazos> TiposRechazos { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
    }
}
