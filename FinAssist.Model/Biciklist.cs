using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Biciklist : EntityBase<int>
    {
        public Biciklist(int id, string ime, string prezime, string oib, DateTime datum) :base(id) 
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oib;
            datRod = datum;
        }
        public Biciklist(int id, string ime, string prezime, string oib, DateTime datum, Bicikl bicikl) : base(id)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oib;
            datRod = datum;
            Bicikl = bicikl;
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public DateTime datRod { get; set; }
        public Bicikl Bicikl { get; set; }
    }
}
