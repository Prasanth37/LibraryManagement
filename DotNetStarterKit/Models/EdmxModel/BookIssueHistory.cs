//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetStarterKit.Models.EdmxModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookIssueHistory
    {
        public long BookIssueHistory1 { get; set; }
        public long UserId { get; set; }
        public string BookNumber { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }
        public Nullable<bool> IsReturned { get; set; }
    }
}
