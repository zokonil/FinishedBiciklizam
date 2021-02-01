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
    public partial class ViewBiciklistForm : Form, IShowBiciklistListView, IObserver
    {
        private List<Biciklist> _listBiciklist = null;
        private IMainFormController _mainFormController = null;
        public ViewBiciklistForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController, List<Biciklist> inListAcc)
        {
            _mainFormController = inMainController;
            _listBiciklist = inListAcc;

            UpdateList();

            this.ShowDialog();
        }

        private void UpdateList() {
            listBiciklisti.Items.Clear();
            for (int i = 0; i < _listBiciklist.Count(); i++) {
                Biciklist biciklist = _listBiciklist[i];

                ListViewItem item = new ListViewItem(biciklist.Ime);
                item.SubItems.Add(biciklist.Prezime);
                item.SubItems.Add(biciklist.OIB);

                listBiciklisti.Items.Add(item);
            }
        }

        private void ViewBiciklistForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainFormController.AddBiciklist();
        }

        public void UpdateView()
        {
            UpdateList();
        }

        private void listBiciklisti_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listBiciklisti.Items.Count; i++)
            {
                var rectangle = listBiciklisti.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    _mainFormController.EditBiciklist(listBiciklisti.Items[i].SubItems[2].Text.ToString());
                    return;
                }
            }
        }
    }
}
