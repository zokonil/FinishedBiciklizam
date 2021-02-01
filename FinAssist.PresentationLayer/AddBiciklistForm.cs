using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biciklizam.BaseLib;
using Biciklizam.Model;

namespace Biciklizam.PresentationLayer
{
    public partial class AddBiciklistForm : Form, IAddNewBiciklistView
    {
        private IMainFormController _mainFormController = null;
        public AddBiciklistForm(IMainFormController inMainController)
        {
            _mainFormController = inMainController;
            InitializeComponent();
        }

        public string Ime => txtBiciklistIme.Text;

        public string Prezime => txtBiciklistPrezime.Text;

        public string OIB => txtBiciklistOIB.Text;

        public DateTime DatumRodenja => dateBiciklistRodenje.Value;

        public Biciklist Biciklist { get; set; }


        public bool ShowViewModal()
        {
            DialogResult result = this.ShowDialog();
            if (result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mainFormController.viewBicikl();
            this.DialogResult = DialogResult.Abort;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddBiciklistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Abort) { 
                e.Cancel = true;
            }
        }
    }
}
