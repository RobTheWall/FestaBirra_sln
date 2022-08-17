using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Shared
{
    public partial class Storni
    {
        public long IdStorni { get; set; }
        public DateTime? DataOra { get; set; }
        public decimal? IdVenditeDettagli { get; set; }
        public decimal? Qta { get; set; }
        public decimal? Prezzo { get; set; }
        public string IdOperatore { get; set; }
    }
}
