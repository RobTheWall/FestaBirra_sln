using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Shared
{
    public partial class Chiusura
    {
        public decimal IdChiusura { get; set; }
        public DateTime? DataOra { get; set; }
        public decimal? NumVendite { get; set; }
        public decimal? Totale { get; set; }
        public string Operatore { get; set; }
        public string Note { get; set; }
    }
}
