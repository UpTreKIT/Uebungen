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
            //string eingabe = "135";
            //string eingabe2 = "ASDF154";
            //string eingabe3 = "10F8TX?PUH";
            //istzahl("52138ABC");
           istzahl("543231");
            //Console.WriteLine($"Ergebnis: {((istzahl(eingabe) == true) ? $"{eingabe} ist eine zahl" : $"{eingabe} ist keine zahl")}");
            //Console.WriteLine($"Ergebnis: {((istzahl(eingabe2) == true) ? $"{eingabe2} ist eine zahl" : $"{eingabe2} ist keine zahl")}");
            //Console.WriteLine($"Ergebnis: {((istzahl(eingabe) == true) ? $"{eingabe3} ist eine zahl" : $"{eingabe3} ist keine zahl")}");

            //bool istzahl1 = istzahl(eingabe);
            //bool istzahl2 = istzahl(eingabe2);
            //bool istzahl3 = istzahl(eingabe3);
            Console.ReadLine();
        }

        static bool istzahl(string eingabe)
        {
            string textToEnter = ">Zahlen_ueberpruefen<";                                                                             //Text mittisch ausgeben 
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.WriteLine($"\t\t\t\t\t\t  {DateTime.Now}");

            bool eingabeistzahl = false;

            for (int i = 0; i < eingabe.Length; i++)                //i++ bedeutet immer eins höher
            {

                Console.Write(eingabe[i]);
                                                                                        //Ab hier gilt:  'Whitelist'
                if (eingabe[i] == '0')                                                      //|
                {                                                                           //|
                    eingabeistzahl = true;                                                  //|  
                }                                                                           //|
                                                                                            //|
                else if (eingabe[i] == '1')                                                 //V
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '2')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '3')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '4')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '5')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '6')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '7')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '8')
                {
                    eingabeistzahl = true;
                }

                else if (eingabe[i] == '9')
                {
                    eingabeistzahl = true;

                    if (eingabeistzahl = true)
                    {
                        Console.WriteLine("Ist eine ganze Zahl");
                    }

                


                }                                                                      //        ^
                                                                                     //Bis hier: |

                else
                {
                    Console.WriteLine(" ist keine reine Zahl");
                }
                               
            }
           
            Console.Write(" " + "ist eine Zahl");
            Console.ReadLine();

            return eingabeistzahl;
        }


    }

}