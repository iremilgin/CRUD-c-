﻿using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class VwUrunlerKategoriSup
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
    }
}
