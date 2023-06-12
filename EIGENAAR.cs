using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp11Solution
{
    public class EIGENAAR
    {
        public required int ID { get; set; }

        public required string Omschrijving { get; set; }

        public string? Voornaam { get; set; }

        public string? Achternaam { get; set; }

        public string? Regio { get; set; }
    }
}
