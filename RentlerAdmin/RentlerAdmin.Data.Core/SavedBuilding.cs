//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentlerAdmin.Data.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class SavedBuilding
    {
        public int UserId { get; set; }
        public long BuildingId { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual User User { get; set; }
    }
}
