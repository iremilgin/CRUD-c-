using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class KritikSeviyeUrunBilgileri
    {
        public string ÜrünAdı { get; set; } = null!;
        public string Kategori { get; set; } = null!;
        public string TedarikçiFirma { get; set; } = null!;
        public short? MinimumSiparişAdedi { get; set; }
        public decimal? BirimFiyat { get; set; }
    }
}
