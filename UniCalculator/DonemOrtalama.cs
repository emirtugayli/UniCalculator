using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UniCalculator.Ders;

namespace UniCalculator
{
    public partial class DonemOrtalama : Form
    {
        public DonemOrtalama()
        {
            InitializeComponent();
            
        }
        
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Ders[] dersler = new Ders[Convert.ToInt32(dersSayiNumeric.Value)];
            for (int i = 0; i < dersSayiNumeric.Value; i++)
            {
                DersGiris dersGirisForm = new DersGiris();
                dersGirisForm.gecmeNotu = Convert.ToDouble(gecmeNotTXT.Text);
                dersler[i] = dersGirisForm.ders;
                dersGirisForm.ShowDialog(); 
            }
            Operations op = new Operations();
            double donemNot = op.donemNotuHesapla(dersler);
            double puan = op.puanHesapla(donemNot);
            String harfKarsilik = op.harfKarsiligi(puan);
            DonemOrtalamaSonuc donemOrtalamaSonucForm = new DonemOrtalamaSonuc();
            donemOrtalamaSonucForm.donemNot = donemNot;
            donemOrtalamaSonucForm.puan = puan;
            donemOrtalamaSonucForm.harfKarsilik = harfKarsilik;
            donemOrtalamaSonucForm.gecmeNot = Convert.ToDouble(gecmeNotTXT.Text);
            donemOrtalamaSonucForm.ShowDialog();
            Close();
        }
    }
}
