using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class PortateListini
    {
        public decimal IdPortate { get; set; }
        public decimal IdListini { get; set; }
        public decimal? Prezzo { get; set; }
    }
}
