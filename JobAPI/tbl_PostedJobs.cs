//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PostedJobs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PostedJobs()
        {
            this.tbl_Ex_Interview_Round1 = new HashSet<tbl_Ex_Interview_Round1>();
            this.tbl_Ex_Quiz_Round2 = new HashSet<tbl_Ex_Quiz_Round2>();
            this.tbl_Ex_Task_Round3 = new HashSet<tbl_Ex_Task_Round3>();
        }
    
        public int ID { get; set; }
        public string Job_Title { get; set; }
        public Nullable<int> PositionID { get; set; }
        public Nullable<int> JobTypeID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<long> CityID { get; set; }
        public string RoomKey { get; set; }
        public Nullable<int> Experience { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Posted_date { get; set; }
        public Nullable<System.DateTime> Closing_date { get; set; }
    
        public virtual tbl_City tbl_City { get; set; }
        public virtual tbl_department tbl_department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ex_Interview_Round1> tbl_Ex_Interview_Round1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ex_Quiz_Round2> tbl_Ex_Quiz_Round2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ex_Task_Round3> tbl_Ex_Task_Round3 { get; set; }
        public virtual tbl_jobtype tbl_jobtype { get; set; }
        public virtual tbl_positions tbl_positions { get; set; }
    }
}
