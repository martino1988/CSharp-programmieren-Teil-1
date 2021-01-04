using System;

namespace _034_Summieren_und_Multiplizieren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, welches in einer Schleife Zahlen von der Konsole einliest. 
            //Die Schleife wird beendet bei Eingabe der Zahl 0. 
            //Geben Sie anschließend die Summe und das Produkt der eingelesenen Zahlen auf der Konsole aus.
            int checker = 1;
            Console.WriteLine("Zahlen zum summieren und multiplizieren eingeben (zum beenden 0 eingeben):");
            int sum = 0;
            int fak = 1;
            while (checker == 1)
            {
                int eingabe = Convert.ToInt32(Console.ReadLine());
                if (eingabe == 0)
                {
                    checker = 0;
                }
                else if(eingabe > 0 || eingabe < 0)
                {
                    sum += eingabe;
                    fak *= eingabe;
                }
            }
            Console.WriteLine("Summe: " + sum + "\nFaktor: " + fak);
        }
    }
}
