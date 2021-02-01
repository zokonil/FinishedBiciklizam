using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Bicikl : EntityBase<int>
    {
        public Bicikl(int id, string marka, string model, BiciklTip tip) : base(id)
        {
            Marka = marka;
            Model = model;
            Tip = tip;
        }
        public Bicikl(int id, string marka, string model, BiciklTip tip, BiciklSpec specs) : base(id)
        {
            Marka = marka;
            Model = model;
            Tip = tip;
            Specs = specs;
        }
        public Bicikl(int id, string marka, string model, BiciklTip tip, BiciklSpec specs, List<BiciklOprema> oprema) : base(id)
        {
            Marka = marka;
            Model = model;
            Tip = tip;
            Specs = specs;
            _listOprema = oprema;
        }

        public void AddOprema(BiciklOprema oprema)
        {
            _listOprema.Add(oprema);
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public BiciklTip Tip { get; set; }
        public BiciklSpec Specs {get; set;}

        public List<BiciklOprema> _listOprema;
    }
}
