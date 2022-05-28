using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class VenditeDettagli
    {
        public decimal IdVenditeDettagli { get; set; }
        public string CodiceMenu { get; set; }
        public string Descri { get; set; }
        public decimal? Qta { get; set; }
        public decimal? Prezzo { get; set; }
        public DateTime? DataOra { get; set; }
        public decimal? IdPortate { get; set; }
        public decimal? IdCassa { get; set; }
        public decimal? IdListino { get; set; }
        public decimal? IdPersona { get; set; }
        public decimal? IdVendite { get; set; }
        public int? Consegnato { get; set; }
    }
}
