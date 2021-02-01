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
using Biciklizam.Model.Repositories;

namespace Biciklizam.PresentationLayer
{
    public partial class BiciklistStatisticsView : Form, IBiciklistStats
    {
        private Biciklist _biciklist = null;
        public BiciklistStatisticsView(Biciklist biciklist)
        {
            _biciklist = biciklist;
            InitializeComponent();
        }

        public bool ShowViewModal(IUtrkaRepository utrkaRepo)
        {
            List<Utrka> utrke = utrkaRepo.getAllUtrka();

            brojUtrkaTxt.Text = Statistike.getBiciklistBrojUtrka(_biciklist, utrke).ToString();
            prosjecnoMjestoTxt.Text = Statistike.getBiciklistProsjecnoMjesto(_biciklist, utrke).ToString();
            ProsjecnaBrzinaTxt.Text = Statistike.getBiciklistProsjecnaBrzina(_biciklist, utrke).ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
