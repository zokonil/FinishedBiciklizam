using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.BaseLib
{
    public interface IAddNewBiciklOprema
    {
        bool ShowViewModal();

        string Naziv { get; }
        string Opis { get; }
    }
}
