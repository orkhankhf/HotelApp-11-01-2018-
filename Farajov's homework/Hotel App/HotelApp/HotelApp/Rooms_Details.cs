//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms_Details
    {
        public int Id { get; set; }
        public Nullable<int> room_id { get; set; }
        public Nullable<int> detail_id { get; set; }
    
        public virtual Room_Details Room_Details { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
