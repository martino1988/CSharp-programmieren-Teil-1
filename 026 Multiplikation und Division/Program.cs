using System;

namespace _026_Multiplikation_und_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie ein Programm für die ganzzahlige Multiplikation und Division zweier int Zahlen i und j.
            Console.Write("Zahl 1 (Ganzzahl!) eingeben: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2 (Ganzzahl!) eingeben: ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            int ergmulti = z1;
            int ergrest = z1;
            int ergdiv = 0;
            //Verwenden Sie aber nur die Operatoren +und –.
            //Multiplikation:
            for(int i = 0; i < (z2 - 1); i++)
            {
                ergmulti += z1;
            }

            //Bei der Division soll auch der Rest ermittelt werden.

            //division:
            for(int i = 0; ergrest > z2; i++)
            {
                ergrest -= z2;
                ergdiv++;
            }
            Console.WriteLine("Ergebnis Multiplikation: {0} \nErgebnis Division: {1}  Rest: {2}", ergmulti, ergdiv, ergrest);
            //Erstellen Sie zuerst ein Struktogramm.
        }
    }
}
