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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Tek Ders
            TekDersOrtalama tekDersForm = new TekDersOrtalama();
            tekDersForm.Show();
        }

        private void showDonemOrt_Click(object sender, EventArgs e)
        {
            DonemOrtalama donemOrtalamaForm = new DonemOrtalama();
            donemOrtalamaForm.Show();
        }

        private void showFinalMinNot_Click(object sender, EventArgs e)
        {
            FinalMinNot finalMinNotForm = new FinalMinNot();
            finalMinNotForm.Show();
        }
    }
}
