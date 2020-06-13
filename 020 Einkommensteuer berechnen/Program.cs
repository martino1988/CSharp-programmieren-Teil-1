using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _020_Einkommensteuer_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Berechnen Sie die Einkommensteuer für das über Konsole eingegebene Jahresgehalt.
            Console.Write("Bruttojahresgehalt eingeben: ");
            double brutto = Convert.ToDouble(Console.ReadLine());

            double stb = 0;

            //Dabei gelten folgende Regeln: 
            if(brutto > 0 && brutto <= 11000)
            {
                Console.WriteLine("Steuerfrei!");
            }

            //𝑆𝑡𝐵= 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−110007000∗1750 𝑓ü𝑟 11000€<𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡≤18000€ 
            else if(brutto > 11000 && brutto <= 18000)
            {
                stb = (brutto - 11000) / 7000 * 1750;
            }

            //𝑆𝑡𝐵= 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−1800013000∗4550 + 1750 𝑓ü𝑟 18000€<𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡≤31000€ 
            else if (brutto > 18000 && brutto <= 31000)
            {
                stb = (brutto - 18000) / 13000 * 4550 + 1750;
            }

            //𝑆𝑡𝐵= 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−3100029000∗12180 + 6300 𝑓ü𝑟 31000€<𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡≤60000€ 
            else if(brutto > 31000 && brutto <= 60000)
            {
                stb = (brutto - 31000) / 29000 * 12180 + 6300;
            }

            //𝑆𝑡𝐵= 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−6000030000∗14400 + 18480 𝑓ü𝑟 60000€<𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡≤90000€ 
            else if(brutto > 60000 && brutto <= 90000)
            {
                stb = (brutto - 60000) / 30000 * 14400 + 18480;
            }

            //𝑆𝑡𝐵= 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−90000910000∗455000+32880 𝑓ü𝑟 90000€<𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡≤1000000€ 
            else if(brutto > 90000 && brutto <= 1000000)
            {
                stb = (brutto - 90000) / 910000 * 455000 + 32880;
            }

            //𝑆𝑡𝐵=(𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡−1000000)∗0.55+487880 𝑓ü𝑟 𝐽𝑎ℎ𝑟𝑒𝑠𝑔𝑒ℎ𝑎𝑙𝑡>1000000€
            else if(brutto > 1000000)
            {
                stb = (brutto - 1000000) * 0.55 + 487880;
            }

            else
                Console.WriteLine("Falsche Eingabe!");

            //Geben Sie auf der Konsole den Steuerbetrag (StB) aus und den Steuersatz in Bezug auf das Jahresgehalt.
            Console.WriteLine("Steuerbetrag: " + stb + "€ \nJahresgehalt: " + (brutto-stb) + "€");
        }
    }
}
