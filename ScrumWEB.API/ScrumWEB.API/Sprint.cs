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
    
    public partial class Sprint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprint()
        {
            this.Task = new HashSet<Task>();
        }
    
        public long ID { get; set; }
        public Nullable<long> ID_Backlog { get; set; }
        public Nullable<long> ID_UserCreate { get; set; }
        public Nullable<System.DateTime> DtCreate { get; set; }
        public Nullable<System.DateTime> DtDone { get; set; }
        public Nullable<System.DateTime> DtInitial { get; set; }
        public Nullable<System.DateTime> DtFinal { get; set; }
    
        public virtual Backlog Backlog { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }
    }
}