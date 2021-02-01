using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Rezultat
    {
        public Rezultat(Biciklist biciklist)
        {
            Biciklist = biciklist;
        }
        public Rezultat(TimeSpan vrijeme, float ukupnaUdaljenost, Biciklist biciklist)
        {
            Vrijeme = vrijeme;
            UkupnaUdaljenost = ukupnaUdaljenost;
            Biciklist = biciklist;
        }
        public Rezultat(TimeSpan vrijeme, float ukupnaUdaljenost, Biciklist biciklist, int mjesto)
        {
            Vrijeme = vrijeme;
            UkupnaUdaljenost = ukupnaUdaljenost;
            Biciklist = biciklist;
            Mjesto = mjesto;
        }
        public TimeSpan Vrijeme { get; set; }
        public float UkupnaUdaljenost { get; set; }
        public int Mjesto { get; set; }

        public Biciklist Biciklist { get; set; }
    }
}
