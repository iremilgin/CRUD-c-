using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class VwToplamAlisveriss
    {
        public string CustomerId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public double? Miktar { get; set; }
    }
}
