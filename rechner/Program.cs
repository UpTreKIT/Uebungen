using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


////|______________________________________________|
////|-------rechner_plus_minus_mal_geteilt---------|
////|----------------------------------------------|
///
namespace rechner_plus_minus_mal_geteilt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool penis = IstZahl("0");

            Console.Write("Rechenoperation eingeben(+, -, * oder /):"); // +, -, *, /

            string eingegeben = Console.ReadLine();
            int ergebnis1 = 0;

            if (eingegeben == "+")
            {
                Console.WriteLine("Rechenoperation + gewaehlt");
                Console.WriteLine("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Das Ergebnis ist: ");
                ergebnis1 = zahl1 + zahl2;

            }

            else if (eingegeben == "-")
            {
                Console.WriteLine("Rechenoperation - gewaehlt");
                Console.WriteLine("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Das Ergebnis ist: ");
                ergebnis1 = zahl1 - zahl2;

            }


            else if (eingegeben == "*")
            {
                Console.WriteLine("Rechenoperation * gewaehlt");
                Console.WriteLine("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Das Ergebnis ist: ");
                ergebnis1 = zahl1 * zahl2;

            }

            else if (eingegeben == "/")
            {
                Console.WriteLine("Rechenoperation / gewaehlt");
                Console.WriteLine("Erste Zahl eingeben: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zweite Zahl eingeben: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());

                if (zahl2 == 0)
                {
                    Console.WriteLine("Du kannst den Wert nicht durch 0 teilen! ");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Das Ergebnis ist: ");
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
        static bool IstZahl(string eingabe)
        {
            bool istzahl = false;
            return istzahl; 
        }
    }
}
