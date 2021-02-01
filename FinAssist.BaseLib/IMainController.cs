using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model.Repositories;
using Biciklizam.Model;

namespace Biciklizam.BaseLib
{
	public interface IMainFormController
	{
		void AddBiciklist();
		void EditBiciklist(string OIB);
		void viewBicikl();
		void AddBiciklOprema();
		List<BiciklOprema> getCurrentOprema();
		List<Rezultat> getCurrentResults();
		void removeOprema(List<string> oprema);
		void ViewUtrke();
		void AddUtrka();
		void EditUtrka(string id);
		void AddRezultat();
		void removeRezultat(List<string> selectedIds);
		void showUtrkaStatistics(Utrka utrka);
		void showBiciklistStatistics(Biciklist biciklist);
	}
}
