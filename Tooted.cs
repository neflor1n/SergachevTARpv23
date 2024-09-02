using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    internal class Tooted
    {
        public string ToodeNimetus { get; set; }
        public int Kalorid { get; set; }

        public Tooted(string toodeNimetus, int kalorid)
        {
            ToodeNimetus = toodeNimetus;
            Kalorid = kalorid;
        }
    }
}
