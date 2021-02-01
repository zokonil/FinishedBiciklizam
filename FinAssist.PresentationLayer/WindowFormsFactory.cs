using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biciklizam.BaseLib;
using Biciklizam.Model;
using Biciklizam.Model.Repositories;


namespace Biciklizam.PresentationLayer
{
	public class WindowFormsFactory : IWindowFormsFactory
	{

        public IShowBiciklistListView CreateBiciklistListView(){
			var newFrm = new ViewBiciklistForm();

			return newFrm;
        }

        public IEditBiciklistView CreateEditBiciklsitView(Biciklist biciklist, IMainFormController mainFormController)
        {
			var newFrm = new EditBiciklistForm(biciklist, mainFormController);

			return newFrm;
        }

		public IAddNewBiciklOprema CreateAddBiciklOpremaView()
        {
			var newFrm = new AddBiciklOprema();

			return newFrm;
        }

        public IAddNewBiciklistView CreateNewBiciklsitView(IMainFormController mainFormController)
        {
			var newFrm = new AddBiciklistForm(mainFormController);

			return newFrm;
        }

        public IAddNewBiciklView CreateViewBiciklForm(Bicikl bicikl, IMainFormController mainFormController)
        {
			var newFrm = new AddBiciklForm(bicikl, mainFormController);

			return newFrm;
		}

        public IShowUtkreView CreateShowUtrkeListView()
        {
			var newFrm = new ViewUtrkeForm();

			return newFrm;
        }

        public IAddNewUtrkaView CreateAddUtrkaView(IMainFormController inMainFormController)
        {
			var newFrm = new AddUtrkaForm(inMainFormController);

			return newFrm;
        }

        public IAddRezultatView CreateAddRezultatView(List<Biciklist> sviBiciklisti, List<Biciklist> dodaniBiciklisti)
        {
			var newFrm = new AddRezultatForm(sviBiciklisti, dodaniBiciklisti);

			return newFrm;
        }

        public IEditUtrkaView CreateEditUtrkaView(Utrka utrka, IMainFormController mainFormController)
        {
            var newFrm = new EditUtrkaForm(mainFormController, utrka);

            return newFrm;
        }
        public IUtrkastats CreateUtrkaStatsView(Utrka utrka)
        {
            var newFrm = new UtrkaStatisticsView(utrka);

            return newFrm;
        }

        public IBiciklistStats CreateBiciklistStatsView(Biciklist biciklist)
        {
            var newFrm = new BiciklistStatisticsView(biciklist);

            return newFrm;
        }
    }
}
