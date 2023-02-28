using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCalculator
{
    public class Operations
    {
        public double totalNotHesapla(double vizeNot , double finalNot)
        {
            vizeNot *= 0.4; finalNot *= 0.6; 
            return vizeNot + finalNot;
        }
        public double puanHesapla(double not)
        {
            double puan;
            if (not < 50)
            {
                puan = 0;
            }
            else if (not >= 50 && not < 55)
            {
                puan = 1;
            }
            else if (not >= 55 && not < 60)
            {
                puan = 1.5;
            }
            else if (not >= 60 && not < 70)
            {
                puan = 2;
            }
            else if (not >= 70 && not < 75)
            {
                puan = 2.5;
            }
            else if (not >= 75 && not < 85)
            {
                puan = 3;
            }
            else if (not >= 85 && not < 90)
            {
                puan = 3.5;
            }
            else
            {
                puan = 4;
            }
            return puan;
        }
        public String harfKarsiligi(double puan)
        {
            String harfNot = "null";
            if (puan == 0)
            {
                harfNot = "FF";
            }
            else if (puan == 1)
            {
                harfNot = "DD";
            }
            else if (puan == 1.5)
            {
                harfNot = "DC";
            }
            else if (puan == 2)
            {
                harfNot = "CC";
            }
            else if (puan == 2.5)
            {
                harfNot = "BC";
            }
            else if (puan == 3)
            {
                harfNot = "BB";
            }
            else if (puan == 3.5)
            {
                harfNot = "AB";
            }
            else if (puan == 4)
            {
                harfNot = "AA";
            }
            return harfNot;
        }
        
        public double finalMinNotHesapla(double vizeNot , double gecmeNot) 
        {
            vizeNot *= 0.4; gecmeNot -= vizeNot;
            gecmeNot = gecmeNot * 10 / 6.0;
            return gecmeNot;
        }
 
        public double donemNotuHesapla(Ders[] dersler)
        {
            double pay = 0;
            double payda = 0;
            for (int i = 0; i < dersler.Length; i++)
            { 
                double dersTotalNot = totalNotHesapla(dersler[i].vizeNot, dersler[i].finalNot);
                pay += (dersler[i].kredi * dersTotalNot);
                payda += dersler[i].kredi;
            }
            return pay/payda;
        }
    }
}
