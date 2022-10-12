using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////|______________________________________________|
////|-------rechner_plus_minus_mal_geteilt---------|
////|----------------------------------------------| 

namespace rechner_plus_minus_mal_geteilt
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] zahlenfolge = new int[] { 465467262, 756, -2, 6};
            int laenge = zahlenfolge.Length;

            string textToEnter = ">RECHNUNGSPROGRAMM<";                                                                             //Text mittisch ausgeben 
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));    //

            Console.WriteLine($"\t\t\t\t\t\t  {DateTime.Now}");                                   // Durch \t platzhalter                    //Datum und Uhrzeit ausgeben 
                                                                                                 

            Console.Write("Rechenoperation eingeben: " + Environment.NewLine + "(+, -, * oder /):"); // +, -, *, /                     // durch + Environment.NewLine + springt text in nächste zeile 

            string eingegeben = Console.ReadLine();
            int ergebnis1 = 0;

            if (eingegeben == "+")
            {
                Console.WriteLine("Rechenoperation + gewaehlt\n");
                Console.Write("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Das Ergebnis ist: ");
                ergebnis1 = zahl1 + zahl2;

            }

            else if (eingegeben == "-")
            {
                Console.WriteLine("Rechenoperation - gewaehlt\n");
                Console.Write("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Das Ergebnis ist: ");
                ergebnis1 = zahl1 - zahl2;

            }


            else if (eingegeben == "*")
            {
                Console.WriteLine("Rechenoperation * gewaehlt\n");
                Console.Write("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Das Ergebnis ist: ");
                ergebnis1 = zahl1 * zahl2;

            }

            else if (eingegeben == "/")
            {
                Console.WriteLine("Rechenoperation / gewaehlt\n");
                Console.Write("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());

                if (zahl2 == 0)
                {
                    Console.WriteLine("Du kannst den Wert nicht durch 0 teilen! ");
                    Console.ReadKey();
                }

                else
                {
                    Console.Write(Environment.NewLine);
                    Console.Write("Das Ergebnis ist: ");
                    ergebnis1 = zahl1 / zahl2;
                }

            }

            else
            {
                Console.WriteLine("Rechenoperation unbekannt");
                Console.ReadKey();
                Environment.Exit(0);
            }


            Console.WriteLine(ergebnis1);




            Console.ReadKey();
        }

            

    }
}
