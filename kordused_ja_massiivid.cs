using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    struct Inimene
    {
        public string Nimi;
        public int Vanus;

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }

    public class kordused_ja_massiivid
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // #1

            //funktsioonid_kordused.GenerateAndPrintSquares();

            // #2

            //funktsioonid_kordused.ArvutaJaValjasta();

            // #3

            //funktsioonid_kordused.VanusJaNimi();

            // #4

            //funktsioonid_kordused.OstaElevant();

            // #5

            //funktsioonid_kordused.ArvaArv();

            // #6

            funktsioonid_kordused.KoostaSuurimArv();
        }
    }
}
