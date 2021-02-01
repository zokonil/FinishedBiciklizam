using Biciklizam.BaseLib;
using Biciklizam.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciklizam.PresentationLayer
{
    public partial class ViewUtrkeForm : Form, IShowUtkreView, IObserver
    {
        private List<Utrka> _listUtrke = null;
        private IMainFormController _mainFormController = null;
        public ViewUtrkeForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController, List<Utrka> listUtrke)
        {
            _mainFormController = inMainController;
            _listUtrke = listUtrke;

            UpdateList();

            this.ShowDialog();
        }
        private void UpdateList()
        {
            utrkeList.Items.Clear();
            for(int i =0; i<_listUtrke.Count();i++)
            {
                Utrka utrka = _listUtrke[i];
                ListViewItem item = new ListViewItem(utrka.Id.ToString());
                item.SubItems.Add(utrka.Datum.ToString());
                item.SubItems.Add(utrka.Duljina.ToString());
                item.SubItems.Add(utrka.Trajanje.Hours.ToString() + " : " + utrka.Trajanje.Minutes.ToString());

                utrkeList.Items.Add(item);
            }
        }

        public void UpdateView()
        {
            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            _mainFormController.AddUtrka();
        }

        private void utrkeList_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < utrkeList.Items.Count; i++)
            {
                var rectangle = utrkeList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    _mainFormController.EditUtrka(utrkeList.Items[i].SubItems[0].Text.ToString());
                    return;
                }
            }
        }
    }
}
