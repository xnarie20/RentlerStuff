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
    
    public partial class UserBank
    {
        public int UserBankId { get; set; }
        public int UserId { get; set; }
        public Nullable<long> PayerAlias { get; set; }
        public Nullable<long> PayeeAlias { get; set; }
        public string AccountName { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual User User { get; set; }
    }
}
