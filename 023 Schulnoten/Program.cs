using System;

namespace _023_Schulnoten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie ein Programm, das für eine vom Benutzer eingegebene Schulnote(1 bis 5), 
            Console.Write("Schulnote (1-5) eingeben: ");
            int note = Convert.ToInt32(Console.ReadLine());

            //die verbale Bezeichnung ausgibt.
            switch (note)
            {
                case 1:
                    Console.WriteLine("Eins");
                    break;
                case 2:
                    Console.WriteLine("Zwei");
                    break;
                case 3:
                    Console.WriteLine("Drei");
                    break;
                case 4:
                    Console.WriteLine("Vier");
                    break;
                case 5:
                    Console.WriteLine("Fünf");
                    break;

                //Bei einer ungültigen Eingabe soll eine Fehlermeldung erfolgen. 
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

           
            //Erstellen Sie zuerst ein Struktogramm!
        }
    }
}
