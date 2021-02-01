using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Kronometar : Utrka
    {
        public Kronometar(int id,float duljina, TimeSpan trajanje, DateTime datum) : base(id, duljina, trajanje, datum) { }

        public override void AddRezultat(Rezultat rezultat)
        {
            _listRezultat.Add(rezultat);
            _listRezultat.Sort(delegate (Rezultat a, Rezultat b)
            {
                return a.Vrijeme.TotalMinutes < b.Vrijeme.TotalMinutes ? -1 : 1;
            });
            for (int i = 0; i < _listRezultat.Count(); i++)
            {
                _listRezultat[i].Mjesto = i + 1;
            }
        }
    }
}
