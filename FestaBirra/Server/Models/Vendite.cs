using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class Vendite
    {
        public decimal IdVendite { get; set; }
        public DateTime? DataOra { get; set; }
        public decimal? IdCassa { get; set; }
        public decimal? IdListino { get; set; }
        public string Note { get; set; }
        public decimal? IdPersona { get; set; }
        public decimal? Totale { get; set; }
        public decimal? Pagato { get; set; }
        public decimal? Resto { get; set; }
        public decimal? IdChiusura { get; set; }
    }
}
