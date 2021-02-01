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
    public partial class AddBiciklForm : Form, IAddNewBiciklView, IObserver
    {
        private IMainFormController _mainFormController = null;
        private List<string> _selectedOprema = new List<string>();
        public AddBiciklForm(Bicikl bicikl, IMainFormController inMainFormController)
        {
            InitializeComponent();
            if (bicikl != null)
            {
                txtMarka.Text = bicikl.Marka;
                txtModel.Text = bicikl.Model;
                tipDropdown.SelectedIndex = bicikl.Tip == BiciklTip.CESTOVNI ? 0 : 1;
                if (bicikl.Specs != null)
                {
                    mjDropdown.SelectedIndex = bicikl.Specs.TipVelicine == Biciklizam.Model.SizeType.MILIMETER ? 0 : 1;
                    velRameTxt.Text = bicikl.Specs.VelicinaRame.ToString();
                    promjerGumeTxt.Text = bicikl.Specs.VelicinaGume.ToString();
                    debljinaGumetxt.Text = bicikl.Specs.DebljinaGume.ToString();
                }
                if (bicikl._listOprema != null)
                {
                    for (int i = 0; i < bicikl._listOprema.Count(); i++)
                    {
                        ListViewItem item = new ListViewItem(bicikl._listOprema[i].Ime);
                        item.SubItems.Add(bicikl._listOprema[i].Opis);
                        opremaList.Items.Add(item);
                    }
                }
            }
            _mainFormController = inMainFormController;
        }

        public string Marka => txtMarka.Text;

        public string Model => txtModel.Text;

        public string Tip => tipDropdown.SelectedItem.ToString();

        public string mjernaJed => mjDropdown.SelectedItem.ToString();

        public string velRame => velRameTxt.Text;

        public string promjGume => promjerGumeTxt.Text;

        public string debljGume => debljinaGumetxt.Text;

        public List<BiciklOprema> Oprema { get; set; }

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainFormController.AddBiciklOprema();
            this.DialogResult = DialogResult.Abort;
        }

        public void UpdateView()
        {
            opremaList.Items.Clear();
            List<BiciklOprema> _listOprema = _mainFormController.getCurrentOprema();
            Oprema = _listOprema;
            for(int i =0; i<_listOprema.Count();i++)
            {
                ListViewItem item = new ListViewItem(_listOprema[i].Ime);
                item.SubItems.Add(_listOprema[i].Opis);
                opremaList.Items.Add(item);
            }
        }

        private void AddBiciklForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void opremaList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                _selectedOprema.Add(e.Item.Text);
            } else
            {
                _selectedOprema.Remove(e.Item.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _mainFormController.removeOprema(_selectedOprema);
            UpdateView();
        }
    }
}
