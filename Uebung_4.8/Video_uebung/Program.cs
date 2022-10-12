<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
     class Program
    {
        static void Main(string[] args)
        {
            int monat = 33;

            switch (monat)
            {
                case 1:
                Console.WriteLine("Januar");
                    break;
                    //----
                case 2:
                    Console.WriteLine("Februar");
                        break;
                    //----
                case 3:
                    Console.WriteLine("März");
                    break;
                //----
                case 4:
                    Console.WriteLine("April");
                    break;
                //----
                case 5:
                    Console.WriteLine("Mai");
                    break;
                //-----
                case 6:
                    Console.WriteLine("Juni");
                    break;
                //----
                case 7:
                    Console.WriteLine("Juli");
                    break;
                //----
                case 8:
                    Console.WriteLine("August");
                    break;
                //-----
                case 9:
                    Console.WriteLine("September");
                    break;
                //-----
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                //----
                case 11:
                    Console.WriteLine("November");
                    break;
                //-----
                case 12:
                    Console.WriteLine("Dezember");
                    break;

                default: 
                    Console.WriteLine("Dieser Monat existiert nicht !" );
                    break;

            }

            Console.ReadKey();
        }
    }
}
namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {




        }

    }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////| _____________________________________________|
////|______________________________________________|
////|--------------Switch_case---------------------|
////|----------------------------------------------|
////|--------------Monatsabfrage-------------------|
////|----------------------------------------------|

namespace monatsabfrage
{
     class Program
    {
        static void Main(string[] args)
        {
            string textToEnter = ">MONATSABFRAGE<";                                                                             //Text mittisch ausgeben 
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.WriteLine($"\t\t\t\t\t\t  {DateTime.Now}");


            Console.Write("Gebe einen Monat in Form einer Zahl ein: ");
            int monat = Convert.ToInt32(Console.ReadLine());    //<------------------Monatszahl eingeben<-------------

            Console.Write(Environment.NewLine);                     //<-----leerzeichen--------

            Console.Write("Der eingegebene Monat lautet: ");
            switch (monat)
            {
                case 1:
                Console.WriteLine("Januar");
                    break;
                    //----
                case 2:
                    Console.WriteLine("Februar");
                        break;
                    //----
                case 3:
                    Console.WriteLine("März");
                    break;
                //----
                case 4:
                    Console.WriteLine("April");
                    break;
                //----
                case 5:
                    Console.WriteLine("Mai");
                    break;
                //-----
                case 6:
                    Console.WriteLine("Juni");
                    break;
                //----
                case 7:
                    Console.WriteLine("Juli");
                    break;
                //----
                case 8:
                    Console.WriteLine("August");
                    break;
                //-----
                case 9:
                    Console.WriteLine("September");
                    break;
                //-----
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                //----
                case 11:
                    Console.WriteLine("November");
                    break;
                //-----
                case 12:
                    Console.WriteLine("Dezember");
                    break;

                default: 
                    Console.WriteLine("Dieser Monat existiert nicht !" );
                    break;

            }

            Console.ReadKey();
        }
    }
>>>>>>> Stashed changes
}