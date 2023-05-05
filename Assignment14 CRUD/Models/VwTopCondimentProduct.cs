using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class VwTopCondimentProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
    }
}
