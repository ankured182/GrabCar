//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrabCarMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class booking_driver
    {
        public int id { get; set; }
        public Nullable<int> user_driver_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<decimal> total { get; set; }
        public string pickup_name { get; set; }
        public Nullable<decimal> pickup_lat { get; set; }
        public Nullable<decimal> pickup_lng { get; set; }
        public string drop_off_name { get; set; }
        public Nullable<decimal> drop_off_lat { get; set; }
        public Nullable<decimal> drop_off_lng { get; set; }
        public Nullable<decimal> distance { get; set; }
        public string estimated_fare { get; set; }
        public string date { get; set; }
        public Nullable<decimal> driver_estm_fare_charge { get; set; }
    }
}
