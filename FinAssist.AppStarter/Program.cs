using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Biciklizam.Controllers;
using Biciklizam.PresentationLayer;
using Biciklizam.MemoryBasedDAL;
using Biciklizam.Model;
using Biciklizam.Model.Repositories;

namespace Biciklizam.AppStarter
{
		static class Program
		{
				[STAThread]
				static void Main()
				{
					WindowFormsFactory _formsFactory = new WindowFormsFactory();

					MainFormController mainController = new MainFormController(_formsFactory, BiciklistRepository.getInstance(), UtrkaRepository.getInstance());

					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Biciklizam.PresentationLayer.frmMainWindow(mainController));
				}
		}
}
