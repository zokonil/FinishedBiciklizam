using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biciklizam.Model;
using Biciklizam.Model.Repositories;
using Biciklizam.BaseLib;

namespace Biciklizam.Controllers
{
    class BiciklistController: Subject
    {
        public Bicikl openedBicikl = null;
        public void ViewBiciklists(IShowBiciklistListView inForm, IBiciklistRepository biciklistRepo, IMainFormController mainController) {
            List<Biciklist> biciklisti = biciklistRepo.getAllBiciklists();

            inForm.ShowModaless(mainController, biciklisti);
        }
        public void ShowBiciklistStats(IBiciklistStats inForm, IUtrkaRepository utrkaRepo)
        {
            inForm.ShowViewModal(utrkaRepo);
        }

        public void ViewBicikl(IAddNewBiciklView inForm, IBiciklistRepository biciklistRepo) { 
            if(inForm.ShowViewModal() == true)
            {
                try
                {
                    string marka = inForm.Marka;
                    string model = inForm.Model;
                    BiciklSpec specs = new BiciklSpec();
                    specs.TipVelicine= inForm.mjernaJed == "Milimetar" ? Biciklizam.Model.SizeType.MILIMETER : Biciklizam.Model.SizeType.INCH;
                    specs.DebljinaGume = float.Parse(inForm.debljGume);
                    specs.VelicinaGume = float.Parse(inForm.promjGume);
                    specs.VelicinaRame = float.Parse(inForm.velRame);

                    List<BiciklOprema> oprema = new List<BiciklOprema>();
                    if(inForm.Oprema!=null)
                    {
                        oprema = inForm.Oprema;
                    }
                    Bicikl bicikl = new Bicikl(1, marka, model, BiciklTip.BRDSKI, specs, oprema);

                    biciklistRepo.setBicikl(bicikl);
                    biciklistRepo.setOprema(oprema);
                }
                catch(Exception e) {
                    Console.WriteLine(e);
                }
            }
        }

        public void AddBiciklOprema(IAddNewBiciklOprema inForm, IBiciklistRepository biciklistRepository)
        {
            if(inForm.ShowViewModal() == true)
            {
                try {
                    string ime = inForm.Naziv;
                    string opis = inForm.Opis;
                    BiciklOprema oprema = new BiciklOprema(ime, opis);


                    biciklistRepository.addOprema(oprema);

                    NotifyObservers();
                } catch(Exception ex) {
                    MessageBox.Show("Exception: " + ex.Message);

                }
            }
        }

        public void AddNewBiciklist(IAddNewBiciklistView inForm, IBiciklistRepository biciklistRepo) { 
            if(inForm.ShowViewModal() == true)
            {
                try
                {
                    string Ime = inForm.Ime;
                    string Prezime = inForm.Prezime;
                    string OIB = inForm.OIB;
                    DateTime Datum = inForm.DatumRodenja;

                    Biciklist biciklist = new Biciklist(biciklistRepo.getNewId(), Ime, Prezime, OIB, Datum);
                    if(biciklistRepo.getBicikl()!=null)
                    {
                        biciklist.Bicikl = biciklistRepo.getBicikl();
                    }

                    biciklistRepo.addBiciklist(biciklist);

                    biciklistRepo.clearBicikl();
                    biciklistRepo.clearOprema();
                    NotifyObservers();
                } catch(BiciklistOIBException ex)
                {
                    MessageBox.Show("Exception: Krivi OIB format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BiciklistNameException ex)
                {
                    MessageBox.Show("Exception: Ime biciklista nije definirano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BiciklistSurnameException ex)
                {
                    MessageBox.Show("Exception: Prezime biciklista nije definirano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void EditBiciklist(IEditBiciklistView inForm, IBiciklistRepository biciklistRepo)
        {
            if (inForm.ShowViewModal() == true)
            {
                try
                {
                    int Id = inForm.Id;
                    string Ime = inForm.Ime;
                    string Prezime = inForm.Prezime;
                    string OIB = inForm.OIB;
                    DateTime Datum = inForm.DatumRodenja;

                    Biciklist biciklist = new Biciklist(Id, Ime, Prezime, OIB, Datum);

                    if (biciklistRepo.getBicikl() != null)
                    {
                        biciklist.Bicikl = biciklistRepo.getBicikl();
                    }

                    biciklistRepo.editBiciklsit(biciklist);

                    biciklistRepo.clearBicikl();
                    biciklistRepo.clearOprema();
                    NotifyObservers();
                }
                catch (BiciklistOIBException ex)
                {
                    MessageBox.Show("Exception: Krivi OIB format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BiciklistNameException ex)
                {
                    MessageBox.Show("Exception: Ime biciklista nije definirano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BiciklistSurnameException ex)
                {
                    MessageBox.Show("Exception: Prezime biciklista nije definirano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
