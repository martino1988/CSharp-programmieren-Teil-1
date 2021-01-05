using System;

namespace _044_Guthaben_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Methode double EndkapitalBerechnen(int guthaben, int laufzeit, double zinssatz). 
            //Diese Methode berechnet den Wert des guthaben nach Ablauf von laufzeit Jahren unter Anwendung von zinssatz 
            //mit Berücksichtigung von Zinseszinsen und gibt das Resultat zurück.

            while (true)
            {
                Console.WriteLine("Guthaben eingeben (ctrl+c zum beenden):");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Laufzeit (in Jahren) eingeben:");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zinssatz eingeben (zB 4,25 für 4,25%):");
                double z = Convert.ToDouble(Console.ReadLine());

                double erg = Endkapitalberechnen(g, l, z);
                Console.WriteLine("Endkapital: " + erg);
            }




        }

        public static double Endkapitalberechnen(int guthaben, int laufzeit, double zinssatz)
        {
            double TempPSatz = 1 + (zinssatz / 100);
            double ErgPSatz = Math.Pow(TempPSatz, laufzeit);
            double Endkapital = guthaben * ErgPSatz;
            return Endkapital;
        }
    }
}
