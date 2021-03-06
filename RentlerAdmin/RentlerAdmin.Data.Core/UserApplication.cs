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
    
    public partial class UserApplication
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public string PresentPhone { get; set; }
        public string PresentAddressLine1 { get; set; }
        public string PresentAddressLine2 { get; set; }
        public string PresentCity { get; set; }
        public string PresentState { get; set; }
        public string PresentZip { get; set; }
        public string PresentLandlord { get; set; }
        public string PresentLandlordPhone { get; set; }
        public string PreviousAddressLine1 { get; set; }
        public string PreviousAddressLine2 { get; set; }
        public string PreviousCity { get; set; }
        public string PreviousState { get; set; }
        public string PreviousZip { get; set; }
        public string PreviousLandlord { get; set; }
        public string PreviousLandlordPhone { get; set; }
        public string PresentEmployer { get; set; }
        public string PresentEmployerPhone { get; set; }
        public string EmergencyContact { get; set; }
        public string PreviousEmployer { get; set; }
        public string PreviousEmployerPhone { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactAddressLine1 { get; set; }
        public string EmergencyContactAddressLine2 { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZip { get; set; }
        public Nullable<int> VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleLicenseNumber { get; set; }
        public string VehicleState { get; set; }
        public bool HasBeenConvicted { get; set; }
        public string ConvictedExplaination { get; set; }
        public bool HasEverBeenUnlawfulDetainer { get; set; }
        public Nullable<System.DateTime> CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual User User { get; set; }
    }
}
