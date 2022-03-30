using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class Selfjoin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? Salary { get; set; }
        public int? ManagerId { get; set; }
    }
}
