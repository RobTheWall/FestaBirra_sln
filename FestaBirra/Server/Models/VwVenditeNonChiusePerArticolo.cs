using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class VwVenditeNonChiusePerArticolo
    {
        public decimal? IdPortate { get; set; }
        public string CodiceMenu { get; set; }
        public string Descri { get; set; }
        public decimal? QtaVendute { get; set; }
        public decimal? Disponibile { get; set; }
        public decimal? SaldoQta { get; set; }
    }
}
