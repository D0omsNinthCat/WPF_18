//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Learn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategorien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategorien()
        {
            this.Artikel = new HashSet<Artikel>();
        }
    
        public int Kategorie_Nr { get; set; }
        public string Kategoriename { get; set; }
        public string Beschreibung { get; set; }
        public byte[] Abbildung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikel> Artikel { get; set; }
    }
}
