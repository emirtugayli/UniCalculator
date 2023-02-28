using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCalculator
{
    public partial class DonemOrtalamaSonuc : Form
    {
        public DonemOrtalamaSonuc()
        {
            InitializeComponent();
        }
        public double gecmeNot = 0;
        public double donemNot = 0;
        public double puan = 0;
        public String harfKarsilik = "";

        private void DonemOrtalamaSonuc_Load(object sender, EventArgs e)
        {
            totalNotTxt.Text = Convert.ToString(donemNot);
            harfPuaniTxt.Text = Convert.ToString(puan);
            harfKarsiligiTxt.Text = harfKarsilik;
            if(donemNot >= gecmeNot)
            {
                gecmeDurumTxt.Text = "Gecti";
            }
            else { gecmeDurumTxt.Text = "Basarisiz"; }
        }
    }
}
