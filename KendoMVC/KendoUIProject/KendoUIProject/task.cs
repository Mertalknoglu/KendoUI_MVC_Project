//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KendoUIProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class task
    {
        public int id { get; set; }
        public string talepno { get; set; }
        public string isadi { get; set; }
        [DataType(DataType.Date)]
        public DateTime? bildirimtarih { get; set; }
        [DataType(DataType.Date)] 
        public DateTime? cozumtarih { get; set; }
        public string issahibi { get; set; }
        public Nullable<byte> durum { get; set; }
    }
}
