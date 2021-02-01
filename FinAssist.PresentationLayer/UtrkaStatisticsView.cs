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
    public partial class UtrkaStatisticsView : Form, IUtrkastats
    {
        public UtrkaStatisticsView(Utrka utrka)
        {
            InitializeComponent();
            brojBiciklistaTxt.Text = Statistike.brojBiciklista(utrka).ToString();
            prisustvovaliTxt.Text = Statistike.brojPris(utrka).ToString();
            prosjecnaUdaljenostTxt.Text = Statistike.prosjecnaUdaljenost(utrka).ToString() +"Km";
            prosjecnaBrzinaTxt.Text = Statistike.prosjecnaBrzina(utrka).ToString()+"Km/h";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
