//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARM_Schedule
    {
        public int ID { get; set; }
        public string Tier3_Auditor { get; set; }
        public string Tier { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> RescheduledDate { get; set; }
        public Nullable<int> BPT_Id { get; set; }
        public string Comments { get; set; }
    }
}
