﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnMobileContainer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnMobileTestEntities : DbContext
    {
        public OnMobileTestEntities()
            : base("name=OnMobileTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblContent> tblContents { get; set; }
        public virtual DbSet<tblContentGallary> tblContentGallaries { get; set; }
        public virtual DbSet<tblGallary> tblGallaries { get; set; }
    }
}
