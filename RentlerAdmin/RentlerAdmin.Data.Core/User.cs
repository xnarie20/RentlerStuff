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
    
    public partial class User
    {
        public User()
        {
            this.Buildings = new HashSet<Building>();
            this.ContactInfoes = new HashSet<ContactInfo>();
            this.Orders = new HashSet<Order>();
            this.SavedBuildings = new HashSet<SavedBuilding>();
            this.UserBanks = new HashSet<UserBank>();
            this.UserCreditCards = new HashSet<UserCreditCard>();
            this.UserInterests = new HashSet<UserInterest>();
        }
    
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public System.Guid ReferenceId { get; set; }
    
        public virtual AffiliateUser AffiliateUser { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<ContactInfo> ContactInfoes { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SavedBuilding> SavedBuildings { get; set; }
        public virtual UserApplication UserApplication { get; set; }
        public virtual ICollection<UserBank> UserBanks { get; set; }
        public virtual ICollection<UserCreditCard> UserCreditCards { get; set; }
        public virtual ICollection<UserInterest> UserInterests { get; set; }
    }
}
