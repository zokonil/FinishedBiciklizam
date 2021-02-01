using System;
using System.Windows.Forms;

using Biciklizam.Model;
using Biciklizam.Controllers;

namespace Biciklizam.PresentationLayer
{
	public partial class frmMainWindow : Form
	{
		private readonly MainFormController _controller;

		public frmMainWindow(MainFormController inController)
		{
			_controller = inController;

			InitializeComponent();
		}

		private void loadDefaultModelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.LoadDefaultModel();
		}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
			_controller.showBiciklisti();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void connectToDataStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prikaziUkupneStatistikeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
			_controller.AddBiciklist();
        }

        private void pregledUtrkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			_controller.ViewUtrke();
        }

        private void dodajUtrkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			_controller.AddUtrka();
        }
    }
}
