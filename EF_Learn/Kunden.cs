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
    
    public partial class Kunden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kunden()
        {
            this.Bestellungen = new HashSet<Bestellungen>();
        }
    
        public string Kunden_Code { get; set; }
        public string Firma { get; set; }
        public string Kontaktperson { get; set; }
        public string Position { get; set; }
        public string Straße { get; set; }
        public string Ort { get; set; }
        public string Region { get; set; }
        public string PLZ { get; set; }
        public string Land { get; set; }
        public string Telefon { get; set; }
        public string Telefax { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bestellungen> Bestellungen { get; set; }
    }
}
