using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_1_1
{
    public class QuizMaster
    {
        public void StarteQuiz()
        {
            //1.Fragen erstellen

            // 5 Fragen.
            string frage1 = "Wie viel bit hat ein Integer?";
            string frage2 = "Wie viele Stunden hat ein Tag?";
            string frage3 = "Welcher Stern in unserem Sonnensystem bewegt sich nicht?";
            string frage4 = "Was ist das Produkt aus 10 x 10?";
            string frage5 = "Ab welchem Alter ist man in Deutschland volljährig?";


            // Antworten zu den Fragen
            string[] antwortenZuFrage1 = new string[2];
            antwortenZuFrage1[0] = "8"; // a
            antwortenZuFrage1[1] = "32";//b

            string[] antwortenZuFrage2 = new string[2];
            antwortenZuFrage2[0] = "24";  //a
            antwortenZuFrage2[1] = "16";  //b

            string[] antwortenZuFrage3 = new string[2];
            antwortenZuFrage3[0] = "Polarstern";  //a
            antwortenZuFrage3[1] = "Alkor";  //b

            string[] antwortenZuFrage4 = new string[2];
            antwortenZuFrage4[0] = "1000";  //a
            antwortenZuFrage4[1] = "100";  //b

            string[] antwortenZuFrage5 = new string[2];
            antwortenZuFrage5[0] = "18";  //a
            antwortenZuFrage5[1] = "21";  //b


            // Frage 1
            Console.WriteLine(frage1);
            Console.WriteLine("a)" + antwortenZuFrage1[0] + "\t\t" + "b)" + antwortenZuFrage1[1]);
            Console.Write(">>>:");
            string antwort = Console.ReadLine();

            Console.WriteLine();
            if (antwort == "a")
            {
                // falsch
                Console.WriteLine("Das war die falsche Antwort: " + antwortenZuFrage1[0]);
            }

            if (antwort == "b")
            {
                Console.WriteLine("Das war die richtige Antwort: " + antwortenZuFrage1[1]);


                // richtig
            }




            // Frage 2
            Console.WriteLine(frage2);
            Console.WriteLine("a)" + antwortenZuFrage2[0] + "\t\t" + "b)" + antwortenZuFrage2[1]);
            Console.Write(">>>:");
            string antwort1 = Console.ReadLine();

            Console.WriteLine();
            if (antwort1 == "a")
            {

                Console.WriteLine("Das war die richtig Antwort: " + antwortenZuFrage2[0]);
            }

            if (antwort1 == "b")
            {

                Console.WriteLine("Das war die falsch Antwort: " + antwortenZuFrage2[1]);

            }

            //Frage 3
            Console.WriteLine(frage3);
            Console.WriteLine("a)" + antwortenZuFrage3[0] + "\t\t" + "b)" + antwortenZuFrage3[1]);
            Console.Write(">>>:");
            string antwort2 = Console.ReadLine();

            Console.WriteLine("                                                                                                                    <==8");
            if (antwort2 == "a")
            {

                Console.WriteLine("Das war die richtig Antwort: " + antwortenZuFrage3[0]);
            }

            if (antwort2 == "b")
            {

                Console.WriteLine("Das war die falsch Antwort: " + antwortenZuFrage3[1]);

            }

            //Frage 4
            Console.WriteLine(frage4);
            Console.WriteLine("a)" + antwortenZuFrage4[0] + "\t\t" + "b)" + antwortenZuFrage4[1]);
            Console.Write(">>>:");
            string antwort3 = Console.ReadLine();

            Console.WriteLine();
            if (antwort3 == "a")
            {

                Console.WriteLine("Das war die falsch Antwort: " + antwortenZuFrage4[0]);
            }

            if (antwort3 == "b")
            {

                Console.WriteLine("Das war die richtig Antwort: " + antwortenZuFrage4[1]);

            }


            //Frage 5
            Console.WriteLine(frage5);
            Console.WriteLine("a)" + antwortenZuFrage5[0] + "\t\t" + "b)" + antwortenZuFrage5[1]);
            Console.Write(">>>:");
            string antwort4 = Console.ReadLine();

            Console.WriteLine();
            if (antwort4 == "a")
            {

                Console.WriteLine("Das war die richtig Antwort: " + antwortenZuFrage5[0]);
            }

            if (antwort4 == "b")
            {

                Console.WriteLine("Das war die falsch Antwort: " + antwortenZuFrage5[1]);

            }




            Console.WriteLine();
        }

    }
}
