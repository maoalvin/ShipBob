//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderTrackng.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderID { get; set; }
        public string TrackingID { get; set; }
        public int UserID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    
        public virtual UserLogin UserLogin { get; set; }
    }
}
