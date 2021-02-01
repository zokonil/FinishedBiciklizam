using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model.Repositories
{
    public interface IBiciklistRepository
    {
		int getBiciklistNum();
		Biciklist getBiciklistByID(int biciklistId);
		Biciklist getBiciklistByName(string Ime);
		Biciklist getBiciklistByOib(string Oib);
		List<Biciklist> getAllBiciklists();
		int getNewId();
		void addBiciklist(Biciklist biciklist);
		void editBiciklsit(Biciklist biciklist);
		void deleteBiciklist(int biciklistId);

		void setBicikl(Bicikl bicikl);
		void clearBicikl();
		Bicikl getBicikl();
		List<BiciklOprema> getOprema();
		void addOprema(BiciklOprema oprema);
		void setOprema(List<BiciklOprema> oprema);
		void clearOprema();
	}
}
