﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TouringDBEntities : DbContext
    {
        public TouringDBEntities()
            : base("name=TouringDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cartilla> Cartillas { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}