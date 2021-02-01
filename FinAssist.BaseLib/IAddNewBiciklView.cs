using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
    public interface IAddNewBiciklView
    {
        bool ShowViewModal();

        string Marka { get; }
        string Model { get; }
        string Tip { get; }
        string mjernaJed { get; }
        string velRame { get; }
        string promjGume { get; }
        string debljGume { get; }
        List<BiciklOprema> Oprema { get; set; }
    }
}
