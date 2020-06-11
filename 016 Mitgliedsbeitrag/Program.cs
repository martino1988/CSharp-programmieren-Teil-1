using System;
using System.Text;

namespace _016_Mitgliedsbeitrag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Ein Verein benötigt ein Programm zur Berechnung von Mitgliedsbeiträgen.
            Console.WriteLine("Mitgliedsbeitrag berechnen:");
            //Der Mitgliedsbeitrag beträgt 500 €. 

            double mb = 500;
            string status = null;

            //Verheiratete Mitglieder bezahlen nur 400 €, 
            //Studenten 300€. 
            //Verheiratete Studenten bezahlen 200 €. 
            //Das Programm soll abfragen, ob das Mitglied verheiratet ist und ob es studiert. 
            
            
            Console.Write("Ist das Mitglied verheiratet? (j/n): ");
            string verh = Console.ReadLine();

            Console.Write("Ist das Mitglied Student? (j/n): ");
            string stud = Console.ReadLine();

            if (verh == "J" || verh == "j" || verh == "y" || verh == "Y")
            {
                mb -= 100;
                status += "verheirtet";
            }
            else
                status += "nicht verheiratet";
                

            if (stud == "J" || stud == "j" || stud == "y" || stud == "Y")
            {
                mb -= 200;
                status += " Student";
            }
            else
                status += " kein Student";

            //Ausgegeben werden soll der jeweils gültige Mitgliedsbeitrag! 
            Console.WriteLine("Mitgliedsbeitrag: " + mb + "€\nStatus: " + status);

            //Erstellen Sie zwei Lösungen: einmal mit geschachteltem if und
            //einmal ohne geschachteltem if.
            //Erstellen Sie auch die passenden Struktogramme.        
        }
    }
}
