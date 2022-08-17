using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Shared
{
    public partial class VwDettagliVenditaByDistribuzione
    {
        public decimal IdVenditeDettagli { get; set; }
        public DateTime? DataOra { get; set; }
        public string CodiceMenu { get; set; }
        public string Descri { get; set; }
        public decimal? Qta { get; set; }
        public decimal? IdCassa { get; set; }
        public string Descrizione { get; set; }
    }
}
