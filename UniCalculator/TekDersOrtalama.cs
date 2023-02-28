using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UniCalculator.Operations;

namespace UniCalculator
{
    public partial class TekDersOrtalama : Form
    {
        public TekDersOrtalama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            double vizeNot = Convert.ToDouble(vizeTxtBox.Text);
            double finalNot = Convert.ToDouble(finalTxtBox.Text);
            double total = op.totalNotHesapla(vizeNot, finalNot);
            double puan = op.puanHesapla(total);
            totalNotTXT.Text = Convert.ToString(total);
            harfPuaniTXT.Text = Convert.ToString(puan);
            harfKarsiligiTXT.Text = Convert.ToString(op.harfKarsiligi(puan));
        }
    }
}
