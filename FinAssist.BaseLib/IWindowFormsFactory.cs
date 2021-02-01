using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
	public interface IWindowFormsFactory
	{
		IShowBiciklistListView CreateBiciklistListView();
		IAddNewBiciklistView CreateNewBiciklsitView(IMainFormController mainFormController);
		IEditBiciklistView CreateEditBiciklsitView(Biciklist biciklist, IMainFormController mainFormController);
		IAddNewBiciklView CreateViewBiciklForm(Bicikl bicikl, IMainFormController mainFormController);
		IAddNewBiciklOprema CreateAddBiciklOpremaView();
		IShowUtkreView CreateShowUtrkeListView();
		IAddNewUtrkaView CreateAddUtrkaView(IMainFormController inMainFormController);
		IAddRezultatView CreateAddRezultatView(List<Biciklist> sviBiciklisti, List<Biciklist> dodaniBiciklisti);
		IEditUtrkaView CreateEditUtrkaView(Utrka utrka, IMainFormController mainFormController);
		IUtrkastats CreateUtrkaStatsView(Utrka utrka);
		IBiciklistStats CreateBiciklistStatsView(Biciklist biciklist);
	}
}
