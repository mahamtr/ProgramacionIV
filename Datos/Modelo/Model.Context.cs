﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AUTOLOTEEntities1 : DbContext
    {
        public AUTOLOTEEntities1()
            : base("name=AUTOLOTEEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_Auto> t_Auto { get; set; }
        public virtual DbSet<t_Localidad> t_Localidad { get; set; }
        public virtual DbSet<t_Orden> t_Orden { get; set; }
        public virtual DbSet<t_Usuarios> t_Usuarios { get; set; }
        public virtual DbSet<getAllOrdenDetalle> getAllOrdenDetalle { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}