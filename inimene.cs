using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public enum Sugu
    {
        mees,
        naine
        
    }
    internal class inimene
    {
        public string Nimi {  get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal {  get; set; }
        public double Aktiivsus { get; set; }
        public inimene()
        {

        }

        public inimene(string nimi)
        {
            Nimi = nimi;
        }
        public inimene(string nimi, int vanus=2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public inimene (string nimi, int vanus, Sugu sugu = Sugu.mees)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            

        }
        public inimene(string nimi, int vanus, Sugu sugu, int pikkus, double kaal, double aktiivsus)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsus = aktiivsus;
        }

        public double HB_vorrand()
        {
            double SBI = 0;
            if (Sugu == Sugu.mees)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            return SBI * Aktiivsus;
        }



    }
}
