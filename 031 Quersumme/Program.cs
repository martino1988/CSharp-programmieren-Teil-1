using System;

namespace _031_Quersumme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quersumme
            //Berechnen Sie die Quersumme einer Zahl, die über Konsole eingegeben wurde. //Die Quersumme bildet man durch die Addition jeder Ziffer der Zahl. Wenn die //Zahl etwa 10938 lautet, so ist die Quersumme 1+0+9+3+8 = 21.
            Console.WriteLine("Zahl zur Berechnung der Quersumme eingeben:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int zwischen = 0;
            if (zahl > 0)
            {
                while (zahl > 0)
                {
                    zwischen = zwischen + (zahl % 10);
                    zahl = zahl / 10;
                }
            }
            else
            {
                Console.WriteLine("Eingabefehler!");
            }
            Console.WriteLine("Quersumme: " + zwischen);

        }
    }
}
