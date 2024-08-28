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

        // #1

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

        // #2
        public static string Jukku(int vanus)
        {
            string eesnimi = "Juku";

            if (eesnimi == "Juku")
            {
                if (vanus < 6)
                {
                    return "Ostame Jukule tasutapileti.";
                }
                else if (vanus >= 6 && vanus <= 14)
                {
                    return "Ostame Jukule lastepileti.";
                }
                else if (vanus >= 15 && vanus <= 65)
                {
                    return "Ostame Jukule täispilet";
                }
                else if (vanus > 65)
                {
                    return "Ostame Jukule sooduspilet";
                }
                else
                {
                    return "Viga andmeid";
                }
            }
            else
            {
                return "Eesnimi ei ole Juku";
            }
        }

        // #3
        public static double originaalHinnaKalkulaator(double discountedPrice, double discountPercentage)
        {
            double discountFraction = discountPercentage / 100;

            double originalPrice = discountedPrice / (1 - discountFraction);

            return originalPrice;
        }

        // #4

        public static string inimeneKorgus(string sugu, int korgus)
        {
            if (sugu == "Mees")
            {
                if (korgus < 165)
                {
                    return "Sa oled lühike kasv mees!";
                }
                else if (korgus >= 166 && korgus <= 180)
                {
                    return "Sa oled keskmist kasvu mees!";
                }
                else
                {
                    return "Sa oled pikka kasvu mees!";
                }
            }
            else if (sugu == "Naine")
            {
                if (korgus < 155)
                {
                    return "Sa oled lühike kasv naine!";
                }
                else if (korgus >= 156 && korgus <= 170)
                {
                    return "Sa oled keskmist kasvu naine!";
                }
                else
                {
                    return "Sa oled pikka kasvu naine!";
                }
            }
            else
            {
                return "teadmata sugu";
            }
        }


        // #5
        public static double Pood()
        {
            const double milkPrice = 1.50;
            const double bunPrice = 0.60;
            const double breadPrice = 0.90;

            double totalCost = 0.0;

            Console.WriteLine("Kui palju piima soovite osta? (sisesta number või 0 kui ei soovi): ");
            int milkQuantity = int.Parse(Console.ReadLine());
            if (milkQuantity > 0)
            {
                totalCost = milkQuantity * milkPrice;
            }

            Console.WriteLine("Kui palju saiat soovite osta? (sisesta number või 0 kui ei soovi): ");
            int bunQuality = int.Parse(Console.ReadLine());
            if (bunQuality > 0)
            {
                totalCost = bunQuality * bunPrice;
            }

            Console.WriteLine("Kui palju leiba soovite osta? (sisesta number või 0 kui ei soovi): ");
            int breadQuality = int.Parse(Console.ReadLine());
            if (breadQuality > 0)
            {
                totalCost = breadQuality * breadPrice;
            }

            return totalCost;
        }

       
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;

                default:
                    paev = "Ei saa määrata!";
                    break;
            }
            return paev;
        }
    }

}



