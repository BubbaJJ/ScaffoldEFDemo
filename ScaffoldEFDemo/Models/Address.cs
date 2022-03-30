using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public int? PostalCode { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}
