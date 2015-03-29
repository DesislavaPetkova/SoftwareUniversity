//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ef_Mapping
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Monasteries = new HashSet<Monastery>();
            this.Rivers = new HashSet<River>();
        }
    
        public string CountryCode { get; set; }
        public string IsoCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencyCode { get; set; }
        public string ContinentCode { get; set; }
        public int Population { get; set; }
        public int AreaInSqKm { get; set; }
        public string Capital { get; set; }
    
        public virtual Continent Continent { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<Monastery> Monasteries { get; set; }
        public virtual ICollection<River> Rivers { get; set; }
    }
}
