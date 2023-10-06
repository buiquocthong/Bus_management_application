//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTicketManagementApplication.src.dbConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class PASSENGER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PASSENGER()
        {
            this.BOOKINGs = new HashSet<BOOKING>();
            this.PASSENGERACCOUNTs = new HashSet<PASSENGERACCOUNT>();
        }
    
        public string id_passenger { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string identity_number { get; set; }
        public Nullable<bool> gender { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKING> BOOKINGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PASSENGERACCOUNT> PASSENGERACCOUNTs { get; set; }
    }
}
