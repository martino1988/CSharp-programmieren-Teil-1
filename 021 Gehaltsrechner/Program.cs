using System;
using System.Text;

namespace _021_Gehaltsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Über die Konsole wird das Basisgehalt und die Anzahl der Kinder eingegeben. 
            Console.Write("Basisgehalt eingeben: ");
            double basis = Convert.ToDouble(Console.ReadLine());

            Console.Write("Anzahl Kinder eingeben: ");
            int kinder = Convert.ToInt32(Console.ReadLine());

            double zuschuss = 0;

            if(kinder == 0)
            {
                zuschuss += 0 * kinder;
            }
            //Bei einem Kind gibt es einen Zuschuss von 100 €, 
            else if(kinder == 1)
            {
                zuschuss += 100 * kinder;
            }

            //bei zwei Kindern gibt es einen Zuschuss von 115 € pro Kind, 
            else if(kinder == 2)
            {
                zuschuss += 115 * kinder;
            }

            //bei mehr als zwei Kindern gibt es einen Zuschuss von 130 € pro Kind. 
            else if(kinder > 2)
            {
                zuschuss += 130 * kinder;
            }

            //Berechnen Sie das Endgehalt.
            Console.WriteLine("Basisgehalt: " + basis + "\nZuschuss: " + zuschuss + "\nEndgehalt: " + (basis + zuschuss) + "€");
        }
    }
}
