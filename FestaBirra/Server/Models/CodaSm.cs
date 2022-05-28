using System;
using System.Collections.Generic;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class CodaSm
    {
        public decimal Id { get; set; }
        public string Nominativo { get; set; }
        public string TestoSms { get; set; }
        public string Operatore { get; set; }
        public string Numero { get; set; }
        public string Stato { get; set; }
        public DateTime? Datains { get; set; }
        public DateTime? Orains { get; set; }
        public DateTime? Datainvio { get; set; }
        public DateTime? Orainvio { get; set; }
    }
}
