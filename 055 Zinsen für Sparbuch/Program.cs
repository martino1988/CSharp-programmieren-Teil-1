using System;

namespace _055_Zinsen_für_Sparbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1A5 – Zinsen für Sparbuch
            //Berechnen Sie für ein Sparguthaben und einen festen Zinssatz (beide Werte werden über Konsole eingegeben) den Zuwachs des Sparguthabens über einen Zeitraum von 10 Jahren. Speichern Sie die Werte in einem Array und geben Sie dann alles auf der Konsole aus.

            Console.WriteLine("Guthaben eingeben");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zinssatz in Prozent eingeben (z.B. 4,4)");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double guthaben = z1;
            double[] sparbuch = new double[11];
            int jahr = 0;
            for (int i = 0; i < sparbuch.Length; i++)
            {
                if (sparbuch[i] == 0)
                {
                    sparbuch[i] = guthaben;
                    guthaben *= (1 + (z2 / 100));
                    jahr++;

                }
            }
            Console.WriteLine("\nStartguthaben: " + sparbuch[0] + "\n");
            foreach (double j in sparbuch)
            {
                Console.WriteLine("Guthaben : {0:F2} Euro", j);
            }
        }
    }
}
