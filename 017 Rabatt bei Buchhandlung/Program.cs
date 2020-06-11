using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace _017_Rabatt_bei_Buchhandlung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Eine Buchhandlung hat folgende Rabattstaffel: 
            //Bei einem Einkauf ab 500 € 20 % Rabatt, 
            //von 300 € bis 499 € 14 %, 
            //von 200 € bis 299 € 8 % und
            //von 100€ S bis 199 € 3 %.
            //Unter 100 € wird kein Rabatt gewährt. 
            //Erstellen Sie ein Programm, das aus dem Einkaufswert den Rabatt und den rabattierten Preis berechnet!        

            Console.Write("Wie hoch war der Einkauf?: ");
            double eink = Convert.ToDouble(Console.ReadLine());
            double rabatt = 0;

            if(eink >= 500)
            {
                rabatt = eink * 0.2;
            }
            else if(eink < 500 && eink >= 300)
            {
                rabatt = eink * 0.14;
            }
            else if(eink < 300 && eink >= 200)
            {
                rabatt = eink * 0.08;
            }
            else if (eink < 200 && eink >= 100)
            {
                rabatt = eink * 0.03;
            }
            else if(eink < 100 && eink > 0)
            {
                rabatt = 0;
            }
            else
                Console.WriteLine("Falsche Eingabe!");
            Console.WriteLine("Endpreis ist: " + (eink - rabatt) + "€" + "\nRabatt beträgt: " + rabatt + "€");


        }
    }
}
