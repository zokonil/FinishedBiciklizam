using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class BiciklOprema
    {
        public BiciklOprema(string ime, string opis)
        {
            Ime = ime;
            Opis = opis;
        }
        public string Ime { get; set; }

        public string Opis { get; set; }
    }
}
