using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biciklizam.Model;
using Biciklizam.Model.Repositories;
using Biciklizam.Model.Factories;
using Biciklizam.BaseLib;

namespace Biciklizam.Controllers
{
    class UtrkaController : Subject
    {
        public Utrka openedUtrka = null;
        private List<Rezultat> _rezultatList = new List<Rezultat>();

        public List<Rezultat> getRezultati()
        {
            return _rezultatList;
        }
        private void clearRezultati()
        {
            _rezultatList.Clear();
        }
        public void setRezultati(List<Rezultat> rezultati)
        {
            _rezultatList = rezultati;
        }
        public void ViewUtrke(IShowUtkreView inForm, IUtrkaRepository utrkaRepo, IMainFormController mainController)
        {
            List<Utrka> listUtrke = utrkaRepo.getAllUtrka();

            inForm.ShowModaless(mainController, listUtrke);
        }
        public void AddNewUtrka(IAddNewUtrkaView inForm, IUtrkaRepository utrkaRepo)
        {
            if(inForm.ShowViewModal()== true)
            {
                try
                {
                    float duljina = float.Parse(inForm.Duljina);
                    TimeSpan trajanje = inForm.Trajanje;
                    DateTime datum = inForm.Datum;
                    string type = inForm.Type;
                    Utrka utrka = UtrkaFactory.CreateUtrka(type, utrkaRepo.getNewId(), duljina, trajanje, datum);

                    for(int i =0;i<_rezultatList.Count();i++)
                    {
                        utrka.AddRezultat(_rezultatList[i]);
                    }

                    utrkaRepo.addUtrka(utrka);
                    clearRezultati();
                    NotifyObservers();
                } 
                catch(Exception ex) {
                    clearRezultati();
                    NotifyObservers();
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }
        public void ShowUtrkaStats(IUtrkastats inForm)
        {
            inForm.ShowViewModal();
        }
        public void EditUtrka(IEditUtrkaView inForm, IUtrkaRepository utrkaRepo)
        {
            if (inForm.ShowViewModal() == true)
            {
                try
                {
                    float duljina = float.Parse(inForm.Duljina);
                    TimeSpan trajanje = inForm.Trajanje;
                    DateTime datum = inForm.Datum;
                    string type = inForm.Type;
                    Utrka utrka = UtrkaFactory.CreateUtrka(type, utrkaRepo.getNewId(), duljina, trajanje, datum);

                    for (int i = 0; i < _rezultatList.Count(); i++)
                    {
                        utrka.AddRezultat(_rezultatList[i]);
                    }

                    utrkaRepo.updateUtrka(utrka);
                    clearRezultati();
                    NotifyObservers();
                }
                catch (Exception ex)
                {
                    clearRezultati();
                    NotifyObservers();
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }
        public void AddNewRezultat(IAddRezultatView inForm, IUtrkaRepository utrkaRepo)
        {
            if (inForm.ShowViewModal() == true)
            {
                try
                {
                    float udaljenost = float.Parse(inForm.Udaljenost);
                    Biciklist biciklist = inForm.Biciklist;
                    TimeSpan trajanje = inForm.Trajanje;

                    Rezultat rez = new Rezultat(trajanje, udaljenost, biciklist);

                    _rezultatList.Add(rez);
                    NotifyObservers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }
    }
}
