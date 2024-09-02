using System;
using System.Collections;
using System.Collections.Generic;
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


            /* Console.WriteLine("Hello World!!!");
             string nimetus = "Python";
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

            // JUKU KINNOS KAIMA 
            Console.Write("Mis on sinu nimi?: ");
            string eesnimi = Console.ReadLine();
            Console.Write('\n');
            Console.WriteLine("Kui vana sa oled?: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("\n");
            string kinno = Funktsioonid.Jukku(vanus);
            Console.WriteLine(kinno);
        }
    }
}
