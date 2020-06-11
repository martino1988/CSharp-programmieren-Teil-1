using System;

namespace _019_Berechnung_der_Tagnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            int jan = 31;
            int febs = 29;
            int febn = 28;
            int mar = 31;
            int apr = 30;
            int mai = 31;
            int jun = 30;
            int jul = 31;
            int aug = 31;
            int sep = 30;
            int okt = 31;
            int nov = 30;
            int dez = 31;

            int zahlmonat = 0;
            int zahltag = 0;
            //Berechnen Sie aus den Eingaben für Tag, Monat und Jahr um den wievielten Tag des Jahres es sich handelt. 
            //Gehen Sie davon aus, dass die Eingaben korrekte Datumsangaben darstellen.
            Console.Write("Jahr eingeben (1601-2399): ");
            int jahr = Convert.ToInt32(Console.ReadLine());


            //Das Jahr liegt zwischen 1601 und 2399.
            if (jahr >= 1601 && jahr <= 2399)
            {
                Console.Write("Monat als Zahl eingeben (1-12): ");
                int monat = Convert.ToInt32(Console.ReadLine());

                if(monat >= 1 && monat <= 12)
                {
                    Console.Write("Tag eingeben (1-31): ");
                    int tag = Convert.ToInt32(Console.ReadLine());

                    //Es gilt weiters:
                    //• Ein Jahr ist Schaltjahr, wenn es durch 4 teilbar ist.
                    //• Ist es aber auch durch 100 teilbar, dann gilt Regel 1 nicht, und es ist kein Schaltjahr.
                    //• Ist es aber auch durch 400 teilbar, dann gilt Regel 2 nicht, und es ist doch ein Schaltjahr.

                    //Schaltjahr prüfen:
                    if (jahr % 4 == 0 && jahr % 100 != 0 || jahr % 400 == 0) // Schaltjahr
                    {
                        if (monat == 1)
                        {
                            zahlmonat = 0;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 2)
                        {
                            zahlmonat = jan;
                            if (tag > 0 && tag <= 29)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 29 sein!");
                        }
                        else if (monat == 3)
                        {
                            zahlmonat = jan + febs;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 4)
                        {
                            zahlmonat = jan + febs + mar;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 5)
                        {
                            zahlmonat = jan + febs + mar + apr;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 6)
                        {
                            zahlmonat = jan + febs + mar + apr + mai;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 7)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 8)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 9)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 10)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 11)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep + okt;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 12)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep + okt + nov;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else
                            Console.WriteLine("Error");
                    }
                    else //kein Schaltjahr
                    {
                        if (monat == 1)
                        {
                            zahlmonat = 0;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 2)
                        {
                            zahlmonat = jan;
                            if (tag > 0 && tag <= 28)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 28 sein!");
                        }
                        else if (monat == 3)
                        {
                            zahlmonat = jan + febs;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 4)
                        {
                            zahlmonat = jan + febs + mar;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 5)
                        {
                            zahlmonat = jan + febs + mar + apr;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 6)
                        {
                            zahlmonat = jan + febs + mar + apr + mai;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 7)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 8)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 9)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 10)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else if (monat == 11)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep + okt;
                            if (tag > 0 && tag <= 30)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 30 sein!");
                        }
                        else if (monat == 12)
                        {
                            zahlmonat = jan + febs + mar + apr + mai + jun + jul + aug + sep + okt + nov;
                            if (tag > 0 && tag <= 31)
                            {
                                zahltag = tag;
                            }
                            else
                                Console.WriteLine("Tag muss zwischen 1 und 31 sein!");
                        }
                        else
                            Console.WriteLine("Error");
                    }
                    Console.WriteLine("\nDer " + tag + "." + monat + "." + jahr + " ist der " + (zahltag + zahlmonat) + " Tag des Jahres " + jahr);
                }
                else
                    Console.WriteLine("Monat muss zwischen 1 und 12 liegen!");
            }
            else
                Console.WriteLine("Jahr muss zwischen 1601 und 2399 liegen!");
        }
    }
}
