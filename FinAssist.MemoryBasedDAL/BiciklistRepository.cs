using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Biciklizam.Model;
using Biciklizam.Model.Repositories;
using Biciklizam.BaseLib;

namespace Biciklizam.MemoryBasedDAL
{
    public class BiciklistRepository : Subject, IBiciklistRepository
    {
        private static int _nextID = 1;
        private static BiciklistRepository _instance;

        private readonly List<Biciklist> _listBiciklist = new List<Biciklist>();
        private Bicikl currentBicikl = null;
        private List<BiciklOprema> currentOprema = new List<BiciklOprema>();
        public static BiciklistRepository getInstance()
        {
            return _instance ?? (_instance = new BiciklistRepository());
        }
        public List<BiciklOprema> getOprema()
        {
            return _instance.currentOprema;
        }
        public void addOprema(BiciklOprema oprema)
        {
            _instance.currentOprema.Add(oprema);
        }
        public void setBicikl(Bicikl bicikl)
        {
            _instance.currentBicikl = bicikl;
        }
        public void clearBicikl()
        {
            _instance.currentBicikl = null;
        }
        public Bicikl getBicikl()
        {
            return _instance.currentBicikl;
        }
        public void addBiciklist(Biciklist biciklist)
        {
            if (string.IsNullOrEmpty(biciklist.OIB) || !Regex.IsMatch(biciklist.OIB, @"^[\p{N}]+$") || biciklist.OIB.Length != 11)
            {
                throw new BiciklistOIBException();
            }
            if (string.IsNullOrEmpty(biciklist.Ime) || !Regex.IsMatch(biciklist.Ime, @"^[\p{L}]+$"))
            {
                throw new BiciklistNameException();
            }
            if (string.IsNullOrEmpty(biciklist.Prezime) || !Regex.IsMatch(biciklist.Prezime, @"^[\p{L}]+$"))
            {
                throw new BiciklistSurnameException();
            }
            _listBiciklist.Add(biciklist);
        }

        public void editBiciklsit(Biciklist biciklist)
        {
            int biciklistIndex = getBiciklistIndex(biciklist);
            if (biciklistIndex != -1) {
                _listBiciklist[biciklistIndex] = biciklist;
            } else
            {
                addBiciklist(biciklist);
            }
        }

        private int getBiciklistIndex(Biciklist biciklist) {
            int index = -1;
            for (int i = 0; i < _listBiciklist.Count(); i++)
            {
                if (_listBiciklist[i].Id == biciklist.Id)
                {
                    index = i;
                }
            }
            return index;
        }

        public void deleteBiciklist(int biciklistId)
        {
            Biciklist itemToRemove = _listBiciklist.SingleOrDefault(r => r.Id==biciklistId);
            if (itemToRemove != null)
            {
                _listBiciklist.Remove(itemToRemove);
            }
        }

        public List<Biciklist> getAllBiciklists()
        {
            return _listBiciklist;
        }

        public Biciklist getBiciklistByID(int biciklistId)
        {
            foreach(Biciklist bic in _listBiciklist)
            {
                if(bic.Id==biciklistId)
                {
                    return bic;
                }
            }
            throw new BiciklistDoesNotExistException();
        }

        public Biciklist getBiciklistByName(string Ime)
        {
            foreach(Biciklist bic in _listBiciklist)
            {
                if(bic.Ime==Ime)
                {
                    return bic;
                }
            }

            throw new BiciklistDoesNotExistException();
        }

        public Biciklist getBiciklistByOib(string Oib)
        {
            foreach(Biciklist bic in _listBiciklist)
            {
                if(bic.OIB==Oib)
                {
                    return bic;
                }
            }

            throw new BiciklistDoesNotExistException();
        }

        public int getBiciklistNum()
        {
            return _listBiciklist.Count;
        }

        public int getNewId()
        {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }

        public void setOprema(List<BiciklOprema> oprema)
        {
            _instance.currentOprema = oprema;
        }
        public void clearOprema()
        {
            _instance.currentOprema = new List<BiciklOprema>();
        }
    }
}
