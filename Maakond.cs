using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public class Maakond
    {



        public static void KuvadaPealinn(Dictionary<string, string> sõnastik)
        {
            Console.Write("Sisestage maakonna nimi: ");
            string maakond = Console.ReadLine();

            if (sõnastik.ContainsValue(maakond))
            {
                // FirstOrDefault возвращает первый элемент коллекции, который соответствует заданному условию
                // используется для получения ключа из словаря, где значение соответствует указанному критерию.
                string pealinn = sõnastik.FirstOrDefault(x => x.Value == maakond).Key;
                Console.WriteLine($"Maakonna {maakond} pealinn on {pealinn}.");
            }
            else
            {
                Console.WriteLine("Sellist maakonda ei leitud.");
            }
        }



        // Funktsioon kuvab maakonna, kui sisestatakse pealinn
        public static void KuvadaMaakond(Dictionary<string, string> sõnastik)
        {
            Console.Write("Sisestage pealinn: ");
            string pealinn = Console.ReadLine();

            if (sõnastik.ContainsKey(pealinn))
            {
                string maakond = sõnastik[pealinn];
                Console.WriteLine($"Pealinna {pealinn} maakond on {maakond}.");
            }
            else
            {
                Console.WriteLine("Sellist pealinna ei leitud.");
            }
        }




        // Funktsioon lisab uue maakonna ja pealinna



        public static void LisaUusMaakond(Dictionary<string, string> sõnastik)
        {
            Console.Write("Sisestage uus pealinn: ");
            string uusPealinn = Console.ReadLine();

            Console.Write("Sisestage selle pealinna maakond: ");
            string uusMaakond = Console.ReadLine();

            if (!sõnastik.ContainsKey(uusPealinn))
            {
                sõnastik[uusPealinn] = uusMaakond;
                Console.WriteLine("Uus pealinn ja maakond on lisatud.");
            }
            else
            {
                Console.WriteLine("See pealinn on juba olemas.");
            }
        }




        // Funktsioon testib sõnastiku tundmist



        public static void TestiTeadmisi(Dictionary<string, string> sõnastik)
        {
            Random random = new Random();
            var pealinnad = sõnastik.Keys.ToList();
            int õigeVastusteArv = 0;

            Console.WriteLine("Test: Sisestage pealinna või maakonna nimi ja näete, kas see on õige.");

            foreach (var pealinn in pealinnad.OrderBy(x => random.Next()))
            {
                Console.Write($"Mis maakonna pealinn on {pealinn}? ");
                string vastus = Console.ReadLine();

                if (vastus.Equals(sõnastik[pealinn], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Õige!");
                    õigeVastusteArv++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus on {sõnastik[pealinn]}.");
                }
            }


            int täpsus = (int)((double)õigeVastusteArv / pealinnad.Count * 100);
            Console.WriteLine($"\nTeie teadmiste testimise tulemus: {täpsus}%");
        }
    }
}

