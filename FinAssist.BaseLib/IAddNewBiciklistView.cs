using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
    public interface IAddNewBiciklistView
    {
        bool ShowViewModal();

        string Ime { get;}
        string Prezime { get; }
        string OIB { get; }
        DateTime DatumRodenja { get; }
        Biciklist Biciklist { get; }
    }
}
