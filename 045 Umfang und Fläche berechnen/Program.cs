using System;

namespace _045_Umfang_und_Fläche_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie zwei Methoden zur Berechnung von Umfang und Fläche eines Rechtecks bzw Quadrats.
            //1. int Umfang(int seiteA, int seiteB)
            //2. int Flaeche(int seiteA, int seiteB)
            while (true)
            {
                Console.WriteLine("Seite A eingeben:");
                double sa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Seite B eingeben:");
                double sb = Convert.ToDouble(Console.ReadLine());

                double u = UmfangBerechnen(sa, sb);
                double f = Flaecheberechnen(sa, sb);
                Console.WriteLine("Umfang: " + u + " Flaeche: " + f);
            }
        }

        public static double UmfangBerechnen(double seiteA, double seiteB)
        {
            return ((2*seiteA)+(2*seiteB));
        }
        public static double Flaecheberechnen(double seiteA, double seiteB)
        {
            return (seiteA*seiteB);
        }
    }
}
