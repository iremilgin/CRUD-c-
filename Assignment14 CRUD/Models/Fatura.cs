using System;
using System.Collections.Generic;

namespace Assignment14_CRUD.Models
{
    public partial class Fatura
    {
        public Fatura()
        {
            FaturaDetays = new HashSet<FaturaDetay>();
        }

        public int FaturaId { get; set; }
        public DateTime? FaturaKesimTarihi { get; set; }
        public int? MusId { get; set; }

        public virtual ICollection<FaturaDetay> FaturaDetays { get; set; }
    }
}
