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
    
    public partial class ANAO_ManualAdjustment
    {
        public string GROUP_SERVICE { get; set; }
        public string WHS_SCA { get; set; }
        public string DESCRIPTION { get; set; }
        public string Stocktake_No { get; set; }
        public string CUSTODIAN_TYPE { get; set; }
        public string SCODE { get; set; }
        public string Scode_Desc { get; set; }
        public Nullable<int> SURPLUS_QTY { get; set; }
        public Nullable<int> DEFICIENT_QTY { get; set; }
        public int ANAO_Id { get; set; }
        public string COMMENTS { get; set; }
    
        public virtual ANAO ANAO { get; set; }
    }
}