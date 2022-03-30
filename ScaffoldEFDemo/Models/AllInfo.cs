using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class AllInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AddressId { get; set; }
        public string StreetAddress { get; set; }
        public int? PostalCode { get; set; }
        public string CityName { get; set; }
    }
}
