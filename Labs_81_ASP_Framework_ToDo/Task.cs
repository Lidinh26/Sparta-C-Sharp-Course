//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Labs_81_ASP_Framework_ToDo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public Nullable<bool> Done { get; set; }
        public Nullable<System.DateTime> DateStarted { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Category Category1 { get; set; }
        public virtual User User { get; set; }
    }
}
