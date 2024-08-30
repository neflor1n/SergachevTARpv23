using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    internal class inimene
    {
        public string Nimi {  get; set; }
        public int Vanus { get; set; }
        
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
    }
}
