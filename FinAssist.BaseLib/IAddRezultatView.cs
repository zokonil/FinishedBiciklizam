using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
    public interface IAddRezultatView
    {
        bool ShowViewModal();

        TimeSpan Trajanje { get; }
        string Udaljenost { get; }
        Biciklist Biciklist { get; }
    }
}
