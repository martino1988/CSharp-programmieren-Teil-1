using System;

namespace _040_Buchstabengenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm welches eine zufällige Anzahl von Großbuchstaben erzeugt und auf der Konsole ausgibt. 
            //Dabei werden nur Konsonanten verwendet, Vokale werden ignoriert. 
            //Sowohl die Anzahl der Buchstaben als auch die Buchstaben selbst werden durch einen Zufallszahlengenerator bestimmt. 
            //Als Zufallszahlengenerator verwenden Sie:
            //Random r = new Random();
            //int z = r.Next(20); // erzeugt eine Zufallszahl zwischen 0 und 19

            //Anzahl Buchstaben:
            Random r = new Random();
            int anzb = r.Next(50);

            Console.WriteLine("Stringlänge: " + anzb);

            for(int i = 0; i < anzb; i++)
            {
                Random rb = new Random();
                int buchst = rb.Next(0, 20);

                switch (buchst)
                {
                    case 1:
                        Console.Write("B");
                        break;
                    case 2:
                        Console.Write("C");
                        break;
                    case 3:
                        Console.Write("D");
                        break;
                    case 4:
                        Console.Write("F");
                        break;
                    case 5:
                        Console.Write("G");
                        break;
                    case 6:
                        Console.Write("H");
                        break;
                    case 7:
                        Console.Write("J");
                        break;
                    case 8:
                        Console.Write("K");
                        break;
                    case 9:
                        Console.Write("L");
                        break;
                    case 10:
                        Console.Write("M");
                        break;
                    case 11:
                        Console.Write("N");
                        break;
                    case 12:
                        Console.Write("P");
                        break;
                    case 13:
                        Console.Write("Q");
                        break;
                    case 14:
                        Console.Write("R");
                        break;
                    case 15:
                        Console.Write("S");
                        break;
                    case 16:
                        Console.Write("T");
                        break;
                    case 17:
                        Console.Write("V");
                        break;
                    case 18:
                        Console.Write("W");
                        break;
                    case 19:
                        Console.Write("X");
                        break;
                    case 20:
                        Console.Write("Y");
                        break;
                    case 0:
                        Console.Write("Z");
                        break;
                    default:
                        Console.WriteLine("Random-Error!!");
                        break;
                }
            }

        }
    }
}
