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
    
    public partial class Bestelldetails
    {
        public int Bestell_Nr { get; set; }
        public int Artikel_Nr { get; set; }
        public decimal Einzelpreis { get; set; }
        public short Anzahl { get; set; }
        public float Rabatt { get; set; }
    
        public virtual Artikel Artikel { get; set; }
        public virtual Bestellungen Bestellungen { get; set; }
    }
}
