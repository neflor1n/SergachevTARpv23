using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Hello World!!!");
            /*  string nimetus = "Python";
             Console.WriteLine(nimetus);
             Console.WriteLine("Hello, my friend, {0}", nimetus);
             //Funktsioonid.Tere(nimetus);
             Console.Write("Sisesta esimene arv: ");
             int a = int.Parse(Console.ReadLine());
             Console.Write('\n');
             Console.Write("Sisesta teine arv: ");
             int b = int.Parse(Console.ReadLine());
             int vastus = Funktsioonid.Liitmine(a, b);
             Console.Write('\n');
             Console.WriteLine("Vastus on: {0}", vastus);
             double arv = 5.123456;
             vastus = Funktsioonid.Liitmine(a, (int)arv);
             Console.Write("\n");
             Console.WriteLine("Vastus on: {0}", vastus);
             char taht = 'A';
             if (vastus == 0)
             {
                 Console.Write('\n');
                 Console.WriteLine(taht);
             }
             else 
             { 
                 Console.WriteLine(vastus);
             }
             */


            // 

            // 1) kalkulaator
            /*
            Console.Write("Sisesta sümbool (+, -, *, /): ");
            char sumbool = char.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Sisesta esimene arv: ");
            double arv5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Sisesta teine arv: ");
            double arv6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            double vastu = Funktsioonid.Arvuta(sumbool, arv5, arv6);
            Console.Write('\n');
            Console.WriteLine("Vastu: {0}", vastu);
            */


            // 2) JUKU KINNOS KAIMA 
            /*
            Console.Write("Mis on sinu nimi?: ");
            string eesnimi = Console.ReadLine().ToUpper();
            Console.Write('\n');
            Console.WriteLine("Kui vana sa oled?: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("\n");
            string kinno = Funktsioonid.Jukku(vanus);
            Console.WriteLine(kinno);
            */

            // 3) Leia ?% hinnasoodustusega hinna põhjal alghind
            /*
            Console.Write("Sisesta allahindluse protsent: ");
            double discountPercentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine('\n');
            Console.Write("Sisesta soodushind: ");
            double discountedPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine('\n');
            double originalPrice = Funktsioonid.originaalHinnaKalkulaator(discountedPrice, discountPercentage);
            Console.WriteLine($"Alghind enne allahindlust: {originalPrice:F2} euro");
            */

            // 4) Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            /*
            Console.Write("Mis on sinu sugu?: ");
            string sugu = Console.ReadLine();
            Console.Write("\nMis on su pikkus sentimeetrites?: ");
            int korgus = int.Parse(Console.ReadLine());
            string korgusKategooria = Funktsioonid.inimeneKorgus(sugu, korgus);
            Console.WriteLine(korgusKategooria);
            */

            // 5) Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
            /*
            double totalCost = Funktsioonid.Pood();
            CultureInfo euroCulture = new CultureInfo("est-EST");

            euroCulture.NumberFormat.CurrencySymbol = "€";

            string formattedCost = totalCost.ToString("C", euroCulture);
            Console.WriteLine($"Ostetud kraam maksab kokku: {formattedCost}");
            */

            Random random = new Random();
            int paev_nr = random.Next(-4, 30);
            string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
            Console.WriteLine("Number: {0}", paev_nr);
            Console.WriteLine(paeva_nimetus);
        }
    }
}
