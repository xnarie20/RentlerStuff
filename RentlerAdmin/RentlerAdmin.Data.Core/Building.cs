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
    
    public partial class Building
    {
        public Building()
        {
            this.BuildingAmenities = new HashSet<BuildingAmenity>();
            this.CustomAmenities = new HashSet<CustomAmenity>();
            this.FeaturedListings = new HashSet<FeaturedListing>();
            this.Orders = new HashSet<Order>();
            this.Photos = new HashSet<Photo>();
            this.SavedBuildings = new HashSet<SavedBuilding>();
            this.UserInterests = new HashSet<UserInterest>();
        }
    
        public long BuildingId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
        public string RibbonId { get; set; }
        public Nullable<System.DateTime> DateRibbonActivated { get; set; }
        public Nullable<int> ContactInfoId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int PropertyTypeCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> SquareFeet { get; set; }
        public Nullable<float> Acres { get; set; }
        public Nullable<int> YearBuilt { get; set; }
        public Nullable<int> Bedrooms { get; set; }
        public Nullable<float> Bathrooms { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> DateAvailableUtc { get; set; }
        public Nullable<System.DateTime> DateActivatedUtc { get; set; }
        public bool IsActive { get; set; }
        public bool IsCreditCheckRequired { get; set; }
        public bool IsBackgroundCheckRequired { get; set; }
        public decimal Deposit { get; set; }
        public decimal RefundableDeposit { get; set; }
        public int LeaseLengthCode { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool ArePetsAllowed { get; set; }
        public bool IsRemovedByAdmin { get; set; }
        public bool IsReported { get; set; }
        public string ReportedText { get; set; }
        public bool IsDeleted { get; set; }
        public bool HasPriority { get; set; }
        public Nullable<System.DateTime> DatePrioritized { get; set; }
        public decimal PetFee { get; set; }
        public Nullable<int> TemporaryOrderId { get; set; }
        public Nullable<System.Guid> PrimaryPhotoId { get; set; }
        public string PrimaryPhotoExtension { get; set; }
    
        public virtual ICollection<BuildingAmenity> BuildingAmenities { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CustomAmenity> CustomAmenities { get; set; }
        public virtual ICollection<FeaturedListing> FeaturedListings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<SavedBuilding> SavedBuildings { get; set; }
        public virtual ICollection<UserInterest> UserInterests { get; set; }
    }
}
