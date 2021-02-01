using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
    public interface IAddNewUtrkaView
    {
        bool ShowViewModal();

        string Duljina { get; }
        TimeSpan Trajanje { get; }
        DateTime Datum { get; }
        string Type { get; }
        List<Rezultat> Rezultati { get; set; }
    }
}
