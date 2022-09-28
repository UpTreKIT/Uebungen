using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zahlen_ueberpuefen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe = "135";
            string eingabe2 = "ASDF154";
            string eingabe3 = "10F8TX?PUH";

            // Console.WriteLine($"Ergebnis: {((istzahl(eingabe) == true) ? $"{eingabe} ist eine zahl": $"{eingabe} ist keine zahl")}");
            //Console.WriteLine($"Ergebnis: {((istzahl(eingabe2) == true) ? $"{eingabe2} ist eine zahl": $"{eingabe2} ist keine zahl")}");
            // Console.WriteLine($"Ergebnis: {((istzahl(eingabe) == true) ? $"{eingabe3} ist eine zahl": $"{eingabe3} ist keine zahl")}");

            bool istzahl1 = istzahl(eingabe);
            bool istzahl2 = istzahl(eingabe2);
            bool istzahl3 = istzahl(eingabe3);
            Console.ReadLine();
        }

        static bool istzahl(string eingabe)
        {
            bool eingabeistzahl = false; 

            for (int i = 0; i < eingabe.Length; i++)
            {
                


            }


            return eingabeistzahl;
        }


    }

}
