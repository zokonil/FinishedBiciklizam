using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.BaseLib
{
    public interface IEditBiciklistView
    {
        bool ShowViewModal();

        int Id { get; }
        string Ime { get; }
        string Prezime { get; }
        string OIB { get; }
        DateTime DatumRodenja { get; }
    }
}
