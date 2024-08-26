using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public class Funktsioonid
    {
       /* public static void Tere(string nimi)
        {
            Console.WriteLine("Tere, {0}", nimi);
        }
        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
       */
        // Loo arvuta funktsioon, mis sõltub 3 parametrist: tehe, arv1, arv2. Kasuta if konstruktsioon. Tulemus kuva ekraanile.
        public static double Arvuta(char tehe, double arv1, double arv2)
        {
            double tulemus;

            if (tehe == '+')
            {
                tulemus = arv1 + arv2;
            }
            else if (tehe == '-')
            {
                tulemus = arv1 - arv2;
            }
            else if (tehe == '*')
            {
                tulemus = arv1 * arv2;
            }
            else if (tehe == '/')
            {
                if (arv2 != 0)
                {
                    tulemus = arv1 / arv2;
                }
                else
                {
                    Console.Error.WriteLine("Jagamine nulliga ei ole lubatud");
                    return 0;
                }
            }
            else
            {
                Console.Error.WriteLine("Tundmatu tehe");
                return 0;
            }

                Console.WriteLine($"Tulemus: {tulemus}");
                return tulemus;
            
        }
        public static string Jukku(int vanus)
        {
            string eesnimi = "Jukku";

            if (eesnimi == "Juku")
            {
                if (vanus < 12)
                {
                    return "Ostame Jukule lastepileti.";
                }
                else if (vanus >= 12 && vanus < 18)
                {
                    return "Ostame Jukule noortepileti.";
                }
                else
                {
                    return "Ostame Jukule täispileti.";
                }
            } else { 

                return "Eesnimi ei ole Juku.";
            }
        }
    }
}

