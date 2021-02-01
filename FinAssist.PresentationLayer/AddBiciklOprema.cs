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

namespace Biciklizam.PresentationLayer
{
    public partial class AddBiciklOprema : Form, IAddNewBiciklOprema
    {
        public string Naziv => txtNaziv.Text;

        public string Opis => txtOpis.Text;

        public AddBiciklOprema()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

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
    }
}
