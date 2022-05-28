using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class Portate
    {
        public decimal IdPortate { get; set; }
        public string CodiceMenu { get; set; }
        public string Descri { get; set; }
        public decimal? IdCentriDistribuzione { get; set; }
        public int? Progressivo { get; set; }
    }
}
