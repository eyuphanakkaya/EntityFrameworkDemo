//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis
    {
        public int SatisId { get; set; }
        public Nullable<int> Urun { get; set; }
        public Nullable<int> Musteri { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Musteri Musteri1 { get; set; }
        public virtual Urun Urun1 { get; set; }
    }
}