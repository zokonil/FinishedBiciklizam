using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class BiciklSpec
    {
        public BiciklSpec() { }
        public BiciklSpec(float velRame, float velGume, float debljGume, SizeType tip)
        {
            VelicinaRame = velRame;
            VelicinaGume = velGume;
            DebljinaGume = debljGume;
            TipVelicine = tip;
        }
        public float VelicinaRame { get; set; }
        public float VelicinaGume { get; set; }
        public float DebljinaGume { get; set; }

        public SizeType TipVelicine { get; set; }
    }
}
