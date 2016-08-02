//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrumWEB.API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Historical_Task = new HashSet<Historical_Task>();
        }
    
        public long ID { get; set; }
        public Nullable<long> ID_Sprint { get; set; }
        public Nullable<long> ID_User { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Done { get; set; }
        public Nullable<int> Difficulty { get; set; }
        public Nullable<System.DateTime> DtCreate { get; set; }
        public Nullable<System.DateTime> DtDone { get; set; }
        public string Title { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> ID_Backlog { get; set; }
    
        public virtual Backlog Backlog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historical_Task> Historical_Task { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual Users Users { get; set; }
    }
}