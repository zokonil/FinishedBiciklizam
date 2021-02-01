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
    public partial class EditUtrkaForm : Form, IEditUtrkaView, IObserver
    {
        private IMainFormController _mainFormController = null;
        private List<string> _selectedIndexList = new List<string>();
        private Utrka _utrka = null;
        public EditUtrkaForm(IMainFormController inMainFormController, Utrka utrka)
        {
            _mainFormController = inMainFormController;
            _utrka = utrka;
            InitializeComponent();
            UpdateView();
            Id = utrka.Id;
            duljinaTxt.Text = utrka.Duljina.ToString();
            TrajanjeBox.Value = new DateTime(2020, 10, 1, utrka.Trajanje.Hours, utrka.Trajanje.Minutes, 0);
            datumBox.Value = utrka.Datum;
            typeBox.SelectedItem = (utrka.GetType() == typeof(Kriterij)) ? "Kriterij" : (utrka.GetType() == typeof(Kronometar)) ? "Kronometar" : "Cestovna utrka";
        }
        public int Id { get; }
        public string Duljina => duljinaTxt.Text;

        public TimeSpan Trajanje => new TimeSpan(TrajanjeBox.Value.Hour, TrajanjeBox.Value.Minute, 0);

        public DateTime Datum => datumBox.Value;

        public List<Rezultat> Rezultati { get; set; }

        public string Type => typeBox.SelectedItem.ToString();


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void UpdateView()
        {
            List<Rezultat> rezultati = _mainFormController.getCurrentResults();
            rezultati.Sort(delegate (Rezultat a, Rezultat b) {
                if (a.Mjesto > b.Mjesto) { return -1; }
                else { return 1; }
            });
            RezultatiList.Items.Clear();
            for (int i = 0; i < rezultati.Count(); i++)
            {
                ListViewItem item = new ListViewItem(rezultati[i].Mjesto.ToString());
                item.SubItems.Add(rezultati[i].Biciklist.Ime);
                item.SubItems.Add(rezultati[i].Biciklist.Prezime);
                item.ImageKey = rezultati[i].Biciklist.Id.ToString();
                RezultatiList.Items.Add(item);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            _mainFormController.AddRezultat();
            this.DialogResult = DialogResult.Abort;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _mainFormController.removeRezultat(_selectedIndexList);
        }

        private void EditUtrkaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void RezultatiList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                _selectedIndexList.Add(e.Item.ImageKey);
            }
            else
            {
                _selectedIndexList.Remove(e.Item.ImageKey);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _mainFormController.showUtrkaStatistics(_utrka);
        }
    }
}
