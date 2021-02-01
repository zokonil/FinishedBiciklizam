using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Utrka : EntityBase<int>
    {
        public Utrka(int id, float duljina, TimeSpan trajanje, DateTime datum) : base(id)
        {
            Duljina = duljina;
            Trajanje = trajanje;
            Datum = datum;
        }
        public float Duljina { get; set; }
        public TimeSpan Trajanje { get; set; }
        public DateTime Datum { get; set; }

        public List<Rezultat> _listRezultat = new List<Rezultat>();
        public virtual void AddRezultat(Rezultat rezultat) { }
    }
}
