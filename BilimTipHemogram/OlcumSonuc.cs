//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilimTipHemogram
{
    using System;
    using System.Collections.Generic;
    
    public partial class OlcumSonuc
    {
        public OlcumSonuc(string sonuc, DateTime islemTarihi)
        {
            Sonuc = sonuc;
            IslemTarihi = IslemTarihi;
        }

        public int Id { get; set; }
        public string Sonuc { get; set; }
        public System.DateTime IslemTarihi { get; set; }
    }
}
