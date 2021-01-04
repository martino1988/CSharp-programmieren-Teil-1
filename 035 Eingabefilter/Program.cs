using System;

namespace _035_Eingabefilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, welches in einer Endlosschleife ganze Zahlen von der Konsole einliest. 
            //Eine positive Zahl wird sofort wieder auf der Konsole ausgegeben. 
            //Eine 0 wird das erste Mal ausgegeben, alle weiteren unmittelbar folgenden 0 werden unterdrückt. 
            //Negative Zahlen werden ebenso unterdrückt. Die Endlosschleife endet bei Eingabe der Zahl -111.

            Console.WriteLine("Zahlen eingeben (mit -111 wird das Programm beendet):");

            int checker = 1;
            int nullchecker = 1;

            while(checker == 1)
            {
                int eing = Convert.ToInt32(Console.ReadLine());
                if(eing == -111)
                {
                    Console.WriteLine("Programm beendet!");
                    checker = 0;
                }
                else if(eing > 0)
                {
                    Console.WriteLine("Eingabe: " + eing);
                }
                else if(eing == 0)
                {
                    if (nullchecker == 1)
                    {
                        Console.WriteLine("Eingabe: " + eing);
                        nullchecker = 0;
                    }
                    else
                        //do nothing
                        ;
                }
                else if(eing < 0 && eing != -111)
                {
                    //do nothing
                }
                else
                    Console.WriteLine("Error!");
            }
        }
    }
}
