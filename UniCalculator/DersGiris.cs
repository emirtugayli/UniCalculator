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
    public partial class DersGiris : Form
    {
        public DersGiris()
        {
            InitializeComponent();   
           
        }
        public double gecmeNotu = 0;
        public Ders ders = new Ders();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            String dersAdi = dersAdiTxtBox.Text;
            double vizeNot = Convert.ToDouble(vizeNotTxtBox.Text);
            double finalNot = Convert.ToDouble(finalNotTxtBox.Text);
            double kredi = Convert.ToDouble(krediTxtBox.Text);
            ders.kredi = kredi; ders.finalNot = finalNot; ders.vizeNot = vizeNot; ders.adi = dersAdi;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            MessageBox.Show("Ders Başarıyla Kaydedildi!");
            Close();
        }
    }
}
