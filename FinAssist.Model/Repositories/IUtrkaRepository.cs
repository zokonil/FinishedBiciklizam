using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model.Repositories
{
    public interface IUtrkaRepository
    {
		int getUtrkaNum();
		Utrka getUtrkaByID(int utrkaId);
		List<Utrka> getAllUtrka();
		int getNewId();
		void addUtrka(Utrka utrka);
		void deleteUtrka(int utrkaId);
		void updateUtrka(Utrka utrka);
	}
}
