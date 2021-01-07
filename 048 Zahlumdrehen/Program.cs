using System;

namespace _048_Zahlumdrehen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Methode int Umdrehen(int n) welche die Ziffern der Zahl n umdreht und diese neue Zahl zurückliefert. 
            //D.h Umdrehen(1234) liefert als Ergebnis die Zahl 4321.
            while (true)
            {
                Console.WriteLine("Zahl zum umdrehen eingeben:");
                int _n = Convert.ToInt32(Console.ReadLine());
                Umdrehen(_n);
            }
        }

        public static void Umdrehen(int n)
        {
            string erg = null;
            while(n > 0)
            {
                int rest = n % 10;
                n = n / 10;
                erg = erg +  rest.ToString();
            }
            int ergebnis = Convert.ToInt32(erg);
            Console.WriteLine("Umgedrehte Zahl: " + ergebnis);
        }
    }
}
