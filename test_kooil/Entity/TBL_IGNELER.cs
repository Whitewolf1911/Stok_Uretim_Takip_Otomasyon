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
    
    public partial class TBL_IGNELER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_IGNELER()
        {
            this.TBL_SIPARIS = new HashSet<TBL_SIPARIS>();
        }
    
        public int ID { get; set; }
        public string IGNEKOD { get; set; }
        public string ISILISLEMFORMUL { get; set; }
        public string NOT { get; set; }
        public byte[] FOTO { get; set; }
        public string TUR { get; set; }
        public Nullable<decimal> GRAMAJ { get; set; }
        public Nullable<int> STOK { get; set; }
        public Nullable<int> HAMMADDETIPI { get; set; }
        public Nullable<decimal> SARFIYATORAN { get; set; }
        public string TESTERE1 { get; set; }
        public string TESTERE2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SIPARIS> TBL_SIPARIS { get; set; }
    }
}
