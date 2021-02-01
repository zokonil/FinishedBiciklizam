using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
    public interface IShowUtkreView
    {
        void ShowModaless(IMainFormController inMainController, List<Utrka> listUtrke);
    }
}
