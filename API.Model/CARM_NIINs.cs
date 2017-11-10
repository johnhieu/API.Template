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
    
    public partial class CARM_NIINs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARM_NIINs()
        {
            this.CARM_CARS = new HashSet<CARM_CARS>();
            this.CARM_Evidences = new HashSet<CARM_Evidences>();
        }
    
        public int ID { get; set; }
        public string Stockcode { get; set; }
        public string Bin_Code { get; set; }
        public Nullable<int> Count { get; set; }
        public int Stocktake_ID { get; set; }
        public Nullable<double> Error_By_Value { get; set; }
        public Nullable<double> Error_By_Volume { get; set; }
        public string Comments { get; set; }
        public Nullable<byte> SaveData { get; set; }
        public Nullable<int> MILIS_Count { get; set; }
        public string Evidences { get; set; }
        public string Type { get; set; }
        public string Briefing { get; set; }
        public string Briefing_Signature { get; set; }
        public string Comments_Signature { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARM_CARS> CARM_CARS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARM_Evidences> CARM_Evidences { get; set; }
        public virtual CARM_Stocktake CARM_Stocktake { get; set; }
    }
}
