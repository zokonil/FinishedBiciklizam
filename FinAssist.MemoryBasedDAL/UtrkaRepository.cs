using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biciklizam.Model;
using Biciklizam.Model.Repositories;

namespace Biciklizam.MemoryBasedDAL
{
    public class UtrkaRepository : IUtrkaRepository
    {
        private static int _nextID = 1;
        private static UtrkaRepository _instance;

        private readonly List<Utrka> _listUtrka = new List<Utrka>();

        public static UtrkaRepository getInstance()
        {
            return _instance ?? (_instance = new UtrkaRepository());
        }
        public void addUtrka(Utrka utrka)
        {
            _listUtrka.Add(utrka);
        }

        public void deleteUtrka(int utrkaId)
        {
            Utrka itemToRemove = _listUtrka.SingleOrDefault(r => r.Id == utrkaId);
            if (itemToRemove != null)
            {
                _listUtrka.Remove(itemToRemove);
            }
        }

        public void updateUtrka(Utrka utrka)
        {
            for(int i=0;i<_listUtrka.Count();i++)
            {
                if(_listUtrka[i].Id==utrka.Id)
                {
                    _listUtrka[i] = utrka;
                    return;
                }
            }
        }

        public List<Utrka> getAllUtrka()
        {
            return _listUtrka;
        }

        public Utrka getUtrkaByID(int utrkaId)
        {
            foreach(Utrka utrka in _listUtrka)
            {
                if (utrka.Id == utrkaId)
                {
                    return utrka;
                }
            }
            throw new UtrkaDoesNotExistException();
        }

        public int getNewId()
        {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }

        public int getUtrkaNum()
        {
            return _listUtrka.Count;
        }
    }
}
