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
    
    public partial class ZipInfo
    {
        public long ZipInfoId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string CityAliasName { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public int ZipCode { get; set; }
    }
}
