//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBL_SIPARIS
    {
        public int SIPARISNOID { get; set; }
        public Nullable<int> IGNETIPI { get; set; }
        public Nullable<System.DateTime> SIPARISTARIHI { get; set; }
        public Nullable<System.DateTime> ISTENILENTARIH { get; set; }
        public string MUSTERI { get; set; }
        public Nullable<int> URUNADETI { get; set; }
        public Nullable<byte> SIPARISASAMASI { get; set; }
        public Nullable<decimal> TOPLAMTUTAR { get; set; }
        public string NOTLAR { get; set; }
        public Nullable<bool> AKTIF { get; set; }
    
        public virtual TBL_IGNELER TBL_IGNELER { get; set; }
    }
}