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
    
    public partial class ANAO_Summary
    {
        public int ID { get; set; }
        public string Group { get; set; }
        public string Custodian_Type { get; set; }
        public string WHS_SCA { get; set; }
        public string Description { get; set; }
        public string StakeNumber { get; set; }
        public int NIINS_Counted { get; set; }
        public int NIINS_In_Error { get; set; }
        public double Error_Rate_By_Niin { get; set; }
        public Nullable<int> NIINS_Placed_Nic { get; set; }
        public int ANAO_Id { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lon { get; set; }
    }
}