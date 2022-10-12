using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

////|______________________________________________|
////|------------Passwort-eingabe------------------|
////|----------------------------------------------|



namespace passwort
{
    internal class Program
    {
        private const string Passwort = "1234";

        private static bool CheckePasswort(string passwort)
        {
            bool passwortcheck = false;

            
            if (passwort.Equals(Passwort)) // Passwort ist korrekt!
            {
                passwortcheck = true;
            }
            else
            {
                passwortcheck = false;
            }

            return passwortcheck;
        }

        static void Main(string[] args)
        {
            //variable für passwort, 
            //eingabe möglichkeit 
            //überprüfung des passworts 
            //versuche zähler 
            //
            string textToEnter = ">Sparkasse Merzig-Wadern<";                                                                             //Text mittisch ausgeben 
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));            // <---Uhrzeit und Datum
            Console.WriteLine($"\t\t\t\t\t\t  {DateTime.Now}");


            for (int i = 0; i < 3; i++)
            {


                string konsolenEingabe = Console.ReadLine();
                bool istPasswortKorrekt = CheckePasswort(konsolenEingabe);

                //Prüfen
                if (istPasswortKorrekt)                         //falls passwort korrekt führt es if aus 
                {
                    Console.WriteLine("Korrekt");
                    break;
                }

                else
                {
                    Console.Write("Eingabe ist falsch" + "Noch 2 versuche");
                    //zählen

                    

                }


            }
            // Eingabe des Passwortes

            

            //Console.Write("Gebe ein Konto in Form einer Zahl ein: (1 oder 2");
            //int monat = Convert.ToInt32(Console.ReadLine());    //<------------------Konto eingeben<-------------

            //Console.Write(Environment.NewLine);                     //<-----leerzeichen--------

            //Console.Write("Das lautet: ");
            //switch (monat)
            //{
            //    case 1:
            //        Console.WriteLine("Januar");
            //        break;






                    Console.ReadKey();
            //}
        }
    }
}
