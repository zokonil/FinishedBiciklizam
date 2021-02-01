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
    public partial class AddUtrkaForm : Form, IAddNewUtrkaView, IObserver
    {
        private IMainFormController _mainFormController = null;
        private List<string> _selectedIndexList = new List<string>();
        public AddUtrkaForm(IMainFormController inMainFormController)
        {
            _mainFormController = inMainFormController;
            InitializeComponent();
            UpdateView();
        }

        public string Duljina => duljinaTxt.Text;

        public TimeSpan Trajanje => new TimeSpan(TrajanjeBox.Value.Hour, TrajanjeBox.Value.Minute, 0);

        public DateTime Datum => datumBox.Value;

        public List<Rezultat> Rezultati { get; set; }

        public string Type => typeBox.SelectedItem.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mainFormController.AddRezultat();
            this.DialogResult = DialogResult.Abort;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _mainFormController.removeRezultat(_selectedIndexList);
        }

        public void UpdateView()
        {
            List<Rezultat> rezultati = _mainFormController.getCurrentResults();
            rezultati.Sort(delegate (Rezultat a, Rezultat b) {
                if (a.Mjesto > b.Mjesto) {return -1;} 
                else { return 1; }
            });
            RezultatiList.Items.Clear();
            for (int i = 0; i < rezultati.Count(); i++) {
                ListViewItem item = new ListViewItem(rezultati[i].Mjesto.ToString());
                item.SubItems.Add(rezultati[i].Biciklist.Ime);
                item.SubItems.Add(rezultati[i].Biciklist.Prezime);
                item.ImageKey = rezultati[i].Biciklist.Id.ToString();
                RezultatiList.Items.Add(item);
            }
        }

        private void AddUtrkaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult==DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void RezultatiList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                _selectedIndexList.Add(e.Item.ImageKey);
            } else
            {
                _selectedIndexList.Remove(e.Item.ImageKey);
            }
        }
    }
}
