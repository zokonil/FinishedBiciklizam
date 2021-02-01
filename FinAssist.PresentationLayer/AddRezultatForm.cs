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
    public partial class AddRezultatForm : Form, IAddRezultatView
    {
        public List<Biciklist> _optionsBiciklisti = new List<Biciklist>();
        public TimeSpan Trajanje => new TimeSpan(TrajanjeBox.Value.Hour, TrajanjeBox.Value.Minute, 0);

        public string Udaljenost => udaljenostTxt.Text;

        public Biciklist Biciklist => _optionsBiciklisti[biciklistCombo.SelectedIndex];

        public AddRezultatForm(List<Biciklist> sviBiciklisti, List<Biciklist> dodaniBiciklisti)
        {
            InitializeComponent();
            biciklistCombo.Items.Clear();
            for (int i = 0; i < sviBiciklisti.Count(); i++) { 
                if(!dodaniBiciklisti.Contains(sviBiciklisti[i]))
                {
                    _optionsBiciklisti.Add(sviBiciklisti[i]);
                    biciklistCombo.Items.Add(sviBiciklisti[i].Ime + sviBiciklisti[i].Prezime);
                }
            }
            biciklistCombo.SelectedIndex = 0;
        }

        private void AddRezultatForm_Load(object sender, EventArgs e)
        {

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
