
﻿using System;
using System.Collections;
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
            

            


            //II. osa listidf ja sõnastikud

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vastus = Console.ReadLine();
            if (vastus != null && arrayList.Contains(vastus))
            {
                Console.WriteLine($"Ostitav element asub {arrayList.IndexOf(vastus)}. kohal");
            }
            else
            {
                Console.WriteLine($"Kokku oli {arrayList.Count} elemente, vaid otsitav puudub");
            }

            arrayList.Clear();
            arrayList.Insert(0, "Anna");
            arrayList.Insert(1, "Inna");
            Console.WriteLine(arrayList);



            List<string> abc = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\abc.txt"))
                {
                    abc.Add(rida);
                }
            
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }

            foreach (string e in abc)
            {
                Console.Write(e);
            }
            Console.ReadLine();


            // #1

            //funktsioonid_kordused.GenerateAndPrintSquares();

            // #2

            // funktsioonid_kordused.ArvutaJaValjasta();

            // #3

            // funktsioonid_kordused.VanusJaNimi();

            // #4

            // funktsioonid_kordused.OstaElevant();

            // #5

            // funktsioonid_kordused.ArvaArv();

            // #6

            // funktsioonid_kordused.KoostaSuurimArv();
        }
    }
}

