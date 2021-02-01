using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model.Repositories;

namespace Biciklizam.BaseLib
{
    public interface IBiciklistStats
    {
        bool ShowViewModal(IUtrkaRepository utrkaRepo);
    }
}
