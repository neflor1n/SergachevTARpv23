using Azure.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public class oppClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            // --------------- Ülessane #1 ---------------

            /*
            Console.WriteLine("Sisesta numbrid: ");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(" ");
            int[] newlist = new int[numblist.Length];
            for (int i = 0; i < numblist.Length; i++)
            {
                int a;
                if (i == 0)
                {
                    a = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[i + 1]);
                }
                else if (i == numblist.Length - 1)
                {
                    a = int.Parse(numblist[i - 1] + int.Parse(numblist[0]));

                }
                else
                {
                    a = int.Parse(numblist[i - 1]) + int.Parse(numblist[i + 1]);
                }

                newlist[i] = a;

            }
            Console.Write("New list of sums: ");
            Console.Write(string.Join(" ", newlist));

            */


            // --------------- Ülessane #2 ---------------

            /*

            // рандомный список чисео
            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++) { 
                numbers.Add(rand.Next(0, 101));
            }

            // Päärisnumbrid
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // Paritu numbrid

            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            // Uus nimekiri, kus kõigepealt lähevad ebaühtlased, seejärel paaris

            List<int> sortNumbers = evenNumbers.Concat(oddNumbers).ToList();

            Console.WriteLine("Sorteeritud numbers: ");
            sortNumbers.ForEach(n => Console.WriteLine(n + " "));


            */

            // --------------- Ülessane #3 ---------------
            
            List<Tooted> tooted = new List<Tooted>
            {
                new Tooted("Õun", 52),
                new Tooted("Banaan", 89),
                new Tooted("Leib", 265),
                new Tooted("Kanafilee", 165),
                new Tooted("Küpsis", 502)
            };

            Console.WriteLine("Введите ежедневную потребность в калориях: ");
            if (!int.TryParse(Console.ReadLine(), out int dailyCalorieNeed))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }

            Console.WriteLine("\nСписок ингредиентов и калорийность на 100 г: ");
            foreach (var item in tooted)
            {
                Console.WriteLine($"{item.ToodeNimetus}: {item.Kalorid} ккал/100 г");
            }

            Console.WriteLine("\nКоличество каждого продукта, которое вы можете потреблять, чтобы удовлетворить ежедневную потребность в калориях: ");

            foreach (var item in tooted)
            {
                // Высчитывает максимальное количество определенного продукта, которое можно потреблять,
                // что бы достичт заданного суточного калорийного лимита
                double maxAmount = (double)dailyCalorieNeed / item.Kalorid * 100;
                Console.WriteLine($"{item.ToodeNimetus}: {maxAmount:F2} г");
            }
        
            

            // --------------- Ülessane #4 ---------------


            Dictionary<string, string> maakonnadPealinnad = new Dictionary<string, string>
            {
            { "Tallinn", "Harjumaa" },
            { "Tartu", "Tartumaa" },
            { "Pärnu", "Pärnumaa" },
            { "Kohtla-Järve", "Ida-Virumaa" },
            { "Viljandi", "Viljandimaa" }
        };

        while (true)
        {
            Console.WriteLine("\nValige tegevus:");
            Console.WriteLine("1. Kuvada pealinn, kui sisestatakse maakonna nimi");
            Console.WriteLine("2. Kuvada maakond, kui sisestatakse pealinn");
            Console.WriteLine("3. Lisada uus maakond ja pealinn");
            Console.WriteLine("4. Testida sõnastiku tundmist");
            Console.WriteLine("5. Väljumine");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    Maakond.KuvadaPealinn(maakonnadPealinnad);
                    break;

                case "2":
                        Maakond.KuvadaMaakond(maakonnadPealinnad);
                    break;

                case "3":
                        Maakond.LisaUusMaakond(maakonnadPealinnad);
                    break;

                case "4":
                        Maakond.TestiTeadmisi(maakonnadPealinnad);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Vale valik, proovige uuesti.");
                    break;
            }
        }






            // III. osa OOP

            Console.WriteLine("\n");
            List<inimene> inimesed = new List<inimene>();
            inimene inimene1 = new inimene();
            inimene1.Nimi = "Pjotr I";
            inimene1.Vanus = 352;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 110;
            inimene inimene2 = new inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Pikkus = 189;
            inimene2.Sugu = Sugu.naine;
            inimene2.Kaal = 70;
            inimene inimene3 = new inimene("Marina", 18, Sugu.naine);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new inimene("Irina", 18));
            foreach (inimene inemene in inimesed)
            {
                Console.WriteLine($"{inemene.Nimi} on " + $"{inemene.Vanus} aastat vana" + $" Ta on {inemene.Sugu}. SBI = {inemene.HB_vorrand()}");

            }
            
            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);
            auto1.KelleOmaAuto();
            Console.WriteLine("\n");
            Dictionary<Auto, inimene> register = new Dictionary<Auto, inimene>();
            register.Add(auto1, inimene2);
            register.Add(auto2, inimene3);
            register.Add(auto3 , inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.Regnumber} - {item.Value.Nimi} ");
                
            }
            Console.WriteLine("\n");
            foreach (KeyValuePair<Auto, inimene> pair in register)
            {
                Console.WriteLine(pair.Key.Regnumber+" - "+pair.Value.Nimi);
            }



        }

    }
}
