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
    
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        public string ProductOption { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
