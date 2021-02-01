using Biciklizam.BaseLib;
using Biciklizam.Model;
using Biciklizam.Model.Repositories;
using Biciklizam.Model.Factories;
using System;
using System.Collections.Generic;

namespace Biciklizam.Controllers
{
	public class MainFormController : IMainFormController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory _formsFactory = null;
		private readonly IBiciklistRepository _biciklistRepo = null;
		private readonly IUtrkaRepository _utrkaRepo = null;
		private static UtrkaController _utrkaController = null;
		private static BiciklistController _bicControler = null;
		public MainFormController(IWindowFormsFactory inFormFactory, IBiciklistRepository biciklistRepo, IUtrkaRepository utrkaRepo)
		{
			_biciklistRepo = biciklistRepo;
			_utrkaRepo = utrkaRepo;
			_formsFactory = inFormFactory;
			_bicControler = new BiciklistController();
			_utrkaController = new UtrkaController();
		}

		public List<Rezultat> getCurrentResults()
        {
			return _utrkaController.getRezultati();
        }

		public void ViewUtrke()
		{
			var utrkaForm = _formsFactory.CreateShowUtrkeListView();

			_utrkaController.Attach((IObserver)utrkaForm);

			_utrkaController.ViewUtrke(utrkaForm, _utrkaRepo, this);

			_utrkaController.Delete((IObserver)utrkaForm);
		}

		public void AddUtrka()
		{
			var newForm = _formsFactory.CreateAddUtrkaView(this);

			_utrkaController.Attach((IObserver)newForm);

			_utrkaController.AddNewUtrka(newForm, _utrkaRepo);

			_utrkaController.Delete((IObserver)newForm);
		}
		public void showUtrkaStatistics(Utrka utrka)
		{
			var utrkaStatForm = _formsFactory.CreateUtrkaStatsView(utrka);

			_utrkaController.ShowUtrkaStats(utrkaStatForm);
		}

		public void showBiciklistStatistics(Biciklist biciklist)
		{
			var biciklistStatsForm = _formsFactory.CreateBiciklistStatsView(biciklist);

			_bicControler.ShowBiciklistStats(biciklistStatsForm, _utrkaRepo);
		}

		public void AddRezultat()
        {
			List<Biciklist> dodaniBiciklisti = new List<Biciklist>();
			List<Rezultat> currentRezultat = _utrkaController.getRezultati();
			for (int i = 0; i < currentRezultat.Count; i++) {
				dodaniBiciklisti.Add(currentRezultat[i].Biciklist);
			}
			var newForm = _formsFactory.CreateAddRezultatView(_biciklistRepo.getAllBiciklists(), dodaniBiciklisti);

			_utrkaController.AddNewRezultat(newForm, _utrkaRepo);
        }
		public void removeRezultat(List<string> selectedIds)
        {
			List<Rezultat> rezultati = _utrkaController.getRezultati();
			List<Rezultat> newRezultati = new List<Rezultat>();
			for(int i =0;i<rezultati.Count;i++)
            {
				if(!selectedIds.Contains(rezultati[i].Biciklist.Id.ToString()))
                {
					newRezultati.Add(rezultati[i]);
                }
            }
			_utrkaController.setRezultati(newRezultati);
			_utrkaController.NotifyObservers();
        }
		public List<BiciklOprema> getCurrentOprema()
		{
			return _biciklistRepo.getOprema();
		}
		public void removeOprema(List<string> oprema)
		{
			List<BiciklOprema> novaOprema = new List<BiciklOprema>();
			List<BiciklOprema> staraOprema = _biciklistRepo.getOprema();
			for (int i = 0; i < staraOprema.Count; i++)
			{
				if (!oprema.Contains(staraOprema[i].Ime))
				{
					novaOprema.Add(staraOprema[i]);
				}
			}
			_biciklistRepo.setOprema(novaOprema);
		}
		public void showBiciklisti()
		{

			var biciklistForm = _formsFactory.CreateBiciklistListView();

			_bicControler.Attach((IObserver)biciklistForm);

			_bicControler.ViewBiciklists(biciklistForm, _biciklistRepo, this);

			_bicControler.Delete((IObserver)biciklistForm);
		}
		public void viewBicikl()
		{
			var biciklForm = _formsFactory.CreateViewBiciklForm(_biciklistRepo.getBicikl(), this);

			_bicControler.Attach((IObserver)biciklForm);

			_bicControler.ViewBicikl(biciklForm, _biciklistRepo);

			_bicControler.Delete((IObserver)biciklForm);
		}
		public void AddBiciklist()
		{
			var newForm = _formsFactory.CreateNewBiciklsitView(this);

			_bicControler.AddNewBiciklist(newForm, _biciklistRepo);
		}

		public void EditUtrka(string id)
		{
			Utrka utrka = _utrkaRepo.getUtrkaByID(int.Parse(id));
			if(utrka!=null)
            {
				_utrkaController.setRezultati(utrka._listRezultat);
				var newForm = _formsFactory.CreateEditUtrkaView(utrka, this);

				_utrkaController.Attach((IObserver)newForm);

				_utrkaController.EditUtrka(newForm, _utrkaRepo);

				_utrkaController.Delete((IObserver)newForm);
			} else
            {
				throw new Exception("Can't find utrka with id: "+id);
            }
		}
		public void EditBiciklist(string OIB)
		{
			Biciklist biciklist = _biciklistRepo.getBiciklistByOib(OIB);
			if (biciklist != null)
			{
				var newForm = _formsFactory.CreateEditBiciklsitView(biciklist, this);

				_biciklistRepo.setBicikl(biciklist.Bicikl);
				if (biciklist.Bicikl != null && biciklist.Bicikl._listOprema != null)
				{
					_biciklistRepo.setOprema(biciklist.Bicikl._listOprema);
				}

				_bicControler.EditBiciklist(newForm, _biciklistRepo);
			}
			else
			{
				throw new BiciklistOIBException();
			}
		}
		public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
				List<BiciklSpec> specs = new List<BiciklSpec>();
				specs.Add(new BiciklSpec(21, 27.5f, 2f, SizeType.INCH));
				specs.Add(new BiciklSpec(530, 584 , 60, SizeType.MILIMETER));
				specs.Add(new BiciklSpec(18, 27.5f, 1f, SizeType.INCH));
				specs.Add(new BiciklSpec(19, 27.0f, 1f, SizeType.INCH));

				List<Bicikl> bicikle = new List<Bicikl>();
				bicikle.Add(new Bicikl(1, "Trek", "4300", BiciklTip.BRDSKI, specs[0]));
				bicikle.Add(new Bicikl(2, "Cannondale", "R-500", BiciklTip.CESTOVNI, specs[1]));
				bicikle.Add(new Bicikl(3, "Cube", "Cross", BiciklTip.CESTOVNI, specs[2]));
				bicikle.Add(new Bicikl(4, "Megamo", "Core", BiciklTip.CESTOVNI, specs[3]));

				List<Biciklist> biciklisti = new List<Biciklist>();
				biciklisti.Add(new Biciklist(_biciklistRepo.getNewId(), "Karlo", "Koncar", "11111111111", new DateTime(1995, 12, 10), bicikle[0]));
				biciklisti.Add(new Biciklist(_biciklistRepo.getNewId(), "Mia", "Radotic", "22222222222", new DateTime(1986, 9, 4), bicikle[1]));
				biciklisti.Add(new Biciklist(_biciklistRepo.getNewId(), "Marko", "Terbotz", "33333333333", new DateTime(2001, 10, 20), bicikle[2]));
				biciklisti.Add(new Biciklist(_biciklistRepo.getNewId(), "Valentino", "Rossi", "44444444444", new DateTime(2020, 6, 12), bicikle[3]));

				List<Utrka> utrke = new List<Utrka>();
				utrke.Add(UtrkaFactory.CreateUtrka("Kronometar", _utrkaRepo.getNewId(), 100.5f,new TimeSpan(3, 0, 0), new DateTime(2021, 1, 21)));
				utrke.Add(UtrkaFactory.CreateUtrka("Kriterij", _utrkaRepo.getNewId(), 100.5f, new TimeSpan(3, 0, 0), new DateTime(2021, 1, 15)));
				utrke.Add(UtrkaFactory.CreateUtrka("Kriterij", _utrkaRepo.getNewId(), 100.5f, new TimeSpan(3, 0, 0), new DateTime(2021, 1, 9)));
				utrke.Add(UtrkaFactory.CreateUtrka("Cestovna utrka", _utrkaRepo.getNewId(), 100.5f, new TimeSpan(3, 0, 0), new DateTime(2021, 1, 29)));

				List<Rezultat> rezultati = new List<Rezultat>();
				
				rezultati.Add(new Rezultat(new TimeSpan(2, 30, 0), 100.5f, biciklisti[0]));
				rezultati.Add(new Rezultat(new TimeSpan(2, 37, 0), 100.5f, biciklisti[1]));
				rezultati.Add(new Rezultat(new TimeSpan(2, 47, 0), 100.5f, biciklisti[2]));

				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 75.5f, biciklisti[0]));
				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 89.5f, biciklisti[3]));
				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 56.5f, biciklisti[2]));

				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 97.5f, biciklisti[0]));
				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 89.5f, biciklisti[1]));
				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 132.5f, biciklisti[2]));
				rezultati.Add(new Rezultat(new TimeSpan(3, 0, 0), 132.5f, biciklisti[3]));

				rezultati.Add(new Rezultat(new TimeSpan(2, 25, 0), 100.5f, biciklisti[2]));
				rezultati.Add(new Rezultat(new TimeSpan(2, 37, 0), 100.5f, biciklisti[1]));
				rezultati.Add(new Rezultat(new TimeSpan(2, 35, 0), 100.5f, biciklisti[0]));
				rezultati.Add(new Rezultat(new TimeSpan(2, 47, 0), 100.5f, biciklisti[3]));

				for(int i=0;i<3; i++)
                {
					utrke[0].AddRezultat(rezultati[i]);
                }
				for (int i = 3; i < 6; i++)
				{
					utrke[1].AddRezultat(rezultati[i]);
				}
				for (int i = 6; i < 10; i++)
				{
					utrke[2].AddRezultat(rezultati[i]);
				}
				for (int i = 10; i < 14; i++)
				{
					utrke[3].AddRezultat(rezultati[i]);
				}

				for(int i = 0; i < biciklisti.Count; i++)
                {
					_biciklistRepo.addBiciklist(biciklisti[i]);
                }
				for (int i = 0; i < utrke.Count; i++)
				{
					_utrkaRepo.addUtrka(utrke[i]);
				}

				_defaultModelLoaded = true;
			}
		}
		public void AddBiciklOprema()
		{
			var biciklistOpremaForm = _formsFactory.CreateAddBiciklOpremaView();

			_bicControler.AddBiciklOprema(biciklistOpremaForm, _biciklistRepo);
		}
    }
}
