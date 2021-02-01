using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biciklizam.Model;
using Biciklizam.BaseLib;

namespace Biciklizam.PresentationLayer
{
    public partial class EditBiciklistForm : Form, IEditBiciklistView
    {
        private IMainFormController _mainFormController = null;
        private Biciklist _biciklist = null;
        public EditBiciklistForm(Biciklist biciklist, IMainFormController inMainFormController)
        {
            InitializeComponent();
            _biciklist = biciklist;
            Id = biciklist.Id;
            this.txtBiciklistIme.Text = biciklist.Ime;
            txtBiciklistPrezime.Text = biciklist.Prezime;
            txtBiciklistOIB.Text = biciklist.OIB;
            dateBiciklistRodenje.Value = biciklist.datRod;
            _mainFormController = inMainFormController;
        }

        public int Id { get; }
        public string Ime => txtBiciklistIme.Text;

        public string Prezime => txtBiciklistPrezime.Text;

        public string OIB => txtBiciklistOIB.Text;

        public DateTime DatumRodenja => dateBiciklistRodenje.Value;

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Biciklbutton_Click(object sender, EventArgs e)
        {
            _mainFormController.viewBicikl();
            this.DialogResult = DialogResult.Abort;
        }

        private void EditBiciklistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mainFormController.showBiciklistStatistics(_biciklist);
            this.DialogResult = DialogResult.Abort;
        }
    }
}
