//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class attendance_day
    {
        public int attday_id { get; set; }
        public Nullable<System.DateTime> attday_date { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> staff_id { get; set; }
        public Nullable<int> year_index { get; set; }
        public string Comment { get; set; }
    }
}