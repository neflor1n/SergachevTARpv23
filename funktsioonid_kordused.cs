
﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{

    // #1
    public class funktsioonid_kordused
    {
        public static void GenerateAndPrintSquares()
        {
            Random rnd = new Random();
            int M = rnd.Next(-100, 101);
            int N = rnd.Next(-100, 101);

            if (M > N)
            {
                int temp = M;
                N = M;
                M = temp;

            }

            Console.WriteLine($"Numbrid vahemikus {N} kuni {M}: ");
            for (int i = 0; i <= M; i++)
            {
                int square = i * i;
                Console.WriteLine($"{i}^2 = {square}");
            }
        }

        // #2
        public static void ArvutaJaValjasta()
        {
            int[] numbrid = new int[5];

            for (int i = 0; i < numbrid.Length; i++)
            {
                Console.Write($"Sisesta arv {i + 1}: ");
                numbrid[i] = int.Parse(Console.ReadLine());
            }

            int summa = numbrid.Sum();

            double keskmine = numbrid.Average();

            int korrutis = 1;
            foreach (int arv in numbrid)
            {
                korrutis *= arv;
            }

            Console.WriteLine($"\nSumma: {summa}");
            Console.WriteLine($"Aritmeetiline keskmine: {keskmine}");
            Console.WriteLine($"Korrutis: {korrutis}");
        }

        // #3
        public static void VanusJaNimi()
        {
            Inimene[] inimesed = new Inimene[5];

            for (int i = 0; i < inimesed.Length; i++)
            {
                Console.Write($"Sisesta oma nimi {i + 1}: ");
                string nimi = Console.ReadLine();

                Console.Write($"\nSisesta oma vanus {i + 1}: ");
                int vanus = int.Parse(Console.ReadLine());

                inimesed[i] = new Inimene(nimi, vanus);

            }

            int summaarneVanus = inimesed.Sum(inimene => inimene.Vanus);
            double keskmineVanus = inimesed.Average(inimene => inimene.Vanus);

            // Нахождение старшего и лмадшего человека
            Inimene vanimInimene = inimesed.OrderByDescending(inimene => inimene.Vanus).First();
            Inimene nooremInimene = inimesed.OrderBy(inimene => inimene.Vanus).First();

            Console.WriteLine($"\nSummaarne vanus: {summaarneVanus}");
            Console.WriteLine($"\nAritmeetiline keskmine vanus: {keskmineVanus}");
            Console.WriteLine($"\nVanim inimene: {vanimInimene.Nimi}, vanus: {vanimInimene.Vanus}");
            Console.WriteLine($"\nNoorim inimene: {nooremInimene.Nimi}, vanus: {nooremInimene.Vanus}");

        }

        // #4
        public static void OstaElevant()
        {
            string kasutajaSisend;

            do
            {
                Console.WriteLine("Osta elevant ära!");

                kasutajaSisend = Console.ReadLine();

            }
            while (!string.Equals(kasutajaSisend, "elevant", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Kasutaja sisestas Elevant. Programm lõpetab.");
        }
        // #5
        public static void ArvaArv()
        {
            Random rand = new Random();
            int arvutiArv = rand.Next(1, 50);

            int katsetusteArv = 0;
            const int maksKatset = 5;
            bool onOigeArvamine = false;

            while (katsetusteArv < maksKatset && !onOigeArvamine)
            {
                Console.WriteLine("Arva arv (1-50): ");
                string sisend = Console.ReadLine();
                int kasutajaArv;

                // проверка на целое число 

                if (int.TryParse(sisend, out kasutajaArv))
                {
                    kasutajaArv++;
                    
                    if (kasutajaArv == arvutiArv)
                    {
                        Console.WriteLine($"\nÕige! Arv oli {arvutiArv}. Kasutaja arvasi õigesti {katsetusteArv} katse jooksul.");
                        onOigeArvamine = true;
                        
                    }
                    else if (kasutajaArv > arvutiArv)
                    {
                        Console.WriteLine("\nVähe! Proovi uuesti.");
                    }
                    else
                    {
                        Console.WriteLine("\nLiigne! Proovi uuesti.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPalun sisesta kehtiv arv.");
                }
            }

            
            if (!onOigeArvamine)
            {
                Console.WriteLine($"\nKahjuks ei suutnud sa arvata õiget arvu. Arv oli {arvutiArv}.");
            }

        }
        // #6

        public static void KoostaSuurimArv()
        {
            int[] arvud = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                while (!int.TryParse(Console.ReadLine(), out arvud[i]))
                {
                    Console.WriteLine("Palun sisesta kehtiv arv.");
                    Console.Write($"Sisesta {i + 1}. arv: ");

                }

            }

            Array.Sort( arvud );
            Array.Reverse( arvud );

            string suurimArv = string.Join( ", ", arvud );
            int.Parse(suurimArv);
            Console.WriteLine($"Suurim neljakohaline arv on: {suurimArv}");
        }
    }

}

