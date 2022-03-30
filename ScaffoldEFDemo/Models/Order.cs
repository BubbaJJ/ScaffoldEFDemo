using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? Quantity { get; set; }
    }
}
