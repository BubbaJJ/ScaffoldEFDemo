using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class BackupAddress
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public int? PostalCode { get; set; }
        public int? CityId { get; set; }
    }
}
