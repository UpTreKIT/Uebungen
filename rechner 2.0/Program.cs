using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


////|______________________________________________|
////|-----------------rechner_minus----------------|
////|----------------------------------------------|

namespace rechner_minus
{
    public class Programm
    {
        static void Main(string[] args)
        {

           // 1.Ganzminuszahl über Console einlesen
           Console.Write("Erste Zahl eingeben: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Zweite zahl eingeben: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int ergebnis = zahl1 - zahl2;
            Console.WriteLine(ergebnis);

            Console.ReadKey();
        }
    }
}