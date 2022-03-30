using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class UsernameHistory
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string OldUsername { get; set; }
        public string NewUsername { get; set; }
        public DateTime? DateChanged { get; set; }
        public string ActionPerformed { get; set; }
    }
}
