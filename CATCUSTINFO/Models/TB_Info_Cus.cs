//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CATCUSTINFO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Info_Cus
    {
        public string CAT_ID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string ACCOUNT_NO { get; set; }
        public Nullable<int> StaNet_ID { get; set; }
        public Nullable<int> PackNet_ID { get; set; }
        public Nullable<int> SpeedNet_ID { get; set; }
        public Nullable<int> RegCAT_ID { get; set; }
        public Nullable<int> SerNet_ID { get; set; }
    }
}
