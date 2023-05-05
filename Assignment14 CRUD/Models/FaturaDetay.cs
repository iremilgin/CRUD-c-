using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class FaturaDetay
    {
        public int FaturaDetayId { get; set; }
        public int? FaturaId { get; set; }
        public int? UrunId { get; set; }
        public int? Adet { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? Tutar { get; set; }

        public virtual Fatura? Fatura { get; set; }
    }
}
