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
    public partial class FinalMinNot : Form
    {
        public FinalMinNot()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            double vizeNot = Convert.ToDouble(vizeNotTxt.Text);
            double gecmeNot = Convert.ToDouble(gecmeNotTxt.Text);
            minNotTxt.Text = Convert.ToString(op.finalMinNotHesapla(vizeNot, gecmeNot));
        }
    }
}
