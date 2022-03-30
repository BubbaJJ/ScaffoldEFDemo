using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class AllFromGothenburg
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AddressId { get; set; }
    }
}
