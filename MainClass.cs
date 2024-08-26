using System;
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


            // 
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
