//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovvvieApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> MovieID { get; set; }
        public Nullable<System.DateTime> DateReadnted { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}
