//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Learn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personal()
        {
            this.Bestellungen = new HashSet<Bestellungen>();
            this.Personal1 = new HashSet<Personal>();
        }
    
        public int Personal_Nr { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Position { get; set; }
        public string Anrede { get; set; }
        public Nullable<System.DateTime> Geburtsdatum { get; set; }
        public Nullable<System.DateTime> Einstellung { get; set; }
        public string Straße { get; set; }
        public string Ort { get; set; }
        public string Region { get; set; }
        public string PLZ { get; set; }
        public string Land { get; set; }
        public string TelefonPrivat { get; set; }
        public string DurchwahlBuero { get; set; }
        public byte[] Foto { get; set; }
        public string Bemerkungen { get; set; }
        public Nullable<int> Vorgesetzter { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bestellungen> Bestellungen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personal1 { get; set; }
        public virtual Personal Personal2 { get; set; }
    }
}
