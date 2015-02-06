﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace EndtoEnd.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using EndtoEnd.Entity;

    public partial class AccountsAtAGlanceEntities : DbContext, IDisposedTracker
    {
        public AccountsAtAGlanceEntities()
            : base("name=AccountsAtAGlanceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Security>().ToTable("Securities");
            modelBuilder.Entity<Securities_Stock>().ToTable("Securities_Stock");
            modelBuilder.Entity<Securities_MutualFund>().ToTable("Securities_MutualFund");
        }
    
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<Securities_MutualFund> Securities_MutualFund { get; set; }
        public virtual DbSet<Securities_Stock> Securities_Stock { get; set; }
        public bool IsDisposed { get; set; }
        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
            base.Dispose(disposing);
        }
    }
}