﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test_kooil.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_kooil_testEntities : DbContext
    {
        public DB_kooil_testEntities()
            : base("name=DB_kooil_testEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_IGNELER> TBL_IGNELER { get; set; }
        public virtual DbSet<TBL_SIPARIS> TBL_SIPARIS { get; set; }
        public virtual DbSet<TBL_KANALACMA> TBL_KANALACMA { get; set; }
        public virtual DbSet<TBL_KONTROL> TBL_KONTROL { get; set; }
        public virtual DbSet<TBL_PRES> TBL_PRES { get; set; }
        public virtual DbSet<TBL_ARKASIYIR> TBL_ARKASIYIR { get; set; }
        public virtual DbSet<TBL_RAPOR> TBL_RAPOR { get; set; }
        public virtual DbSet<TBL_YOLKOPYALA> TBL_YOLKOPYALA { get; set; }
        public virtual DbSet<TBL_BILEME> TBL_BILEME { get; set; }
        public virtual DbSet<TBL_DILCAKMA> TBL_DILCAKMA { get; set; }
        public virtual DbSet<TBL_ISILISLEM> TBL_ISILISLEM { get; set; }
        public virtual DbSet<TBL_KANALBUYUTME> TBL_KANALBUYUTME { get; set; }
        public virtual DbSet<TBL_POLISAJ1> TBL_POLISAJ1 { get; set; }
        public virtual DbSet<TBL_POLISAJ2> TBL_POLISAJ2 { get; set; }
        public virtual DbSet<TBL_TEMPER> TBL_TEMPER { get; set; }
        public virtual DbSet<TBL_UCSIYIRMA> TBL_UCSIYIRMA { get; set; }
        public virtual DbSet<TBL_YIKAMA> TBL_YIKAMA { get; set; }
        public virtual DbSet<TBL_HAMMADDE> TBL_HAMMADDE { get; set; }
        public virtual DbSet<TBL_HAMRAPOR> TBL_HAMRAPOR { get; set; }
        public virtual DbSet<TBL_FIRMALAR> TBL_FIRMALAR { get; set; }
        public virtual DbSet<TBL_SEVKIYAT> TBL_SEVKIYAT { get; set; }
        public virtual DbSet<TBL_USERS> TBL_USERS { get; set; }
        public virtual DbSet<TBL_HAMLOG> TBL_HAMLOG { get; set; }
        public virtual DbSet<TBL_IADE> TBL_IADE { get; set; }
        public virtual DbSet<TBL_URUNSTOKLOG> TBL_URUNSTOKLOG { get; set; }
        public virtual DbSet<TBL_TESTERE> TBL_TESTERE { get; set; }
    }
}
