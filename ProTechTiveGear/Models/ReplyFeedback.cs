//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProTechTiveGear.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReplyFeedback
    {
        public long ID { get; set; }
        public string Content { get; set; }
        public Nullable<long> FeedBackID { get; set; }
        public Nullable<long> CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Feedback Feedback { get; set; }
    }
}
