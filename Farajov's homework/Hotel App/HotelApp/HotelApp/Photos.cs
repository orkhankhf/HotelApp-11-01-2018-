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
    
    public partial class Photos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photos()
        {
            this.Rooms_Photos = new HashSet<Rooms_Photos>();
        }
    
        public int id { get; set; }
        public string image_name { get; set; }
        public string image_src { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rooms_Photos> Rooms_Photos { get; set; }
    }
}
