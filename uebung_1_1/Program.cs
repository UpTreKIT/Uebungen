using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
////|____________________________________________|
////|--------------\/anfang\/--------------------|
////|--------------------------------------------|
//namespace uebung_1_1
//{
//public class program1
//{
//  static void main(string[] args)
// {
//     console.writeline("hello world");


//     console.readline();
//   }
//}
//}
////|______________________________________________|
////|------Tastenkombi-:---STRG-+-K-+-U------------|
////|----------------------------------------------|

namespace uebung_1_1_1
{
    public class Program2
    {
        private static Random _zufallsGenerator = new Random();

        private static void TestArray()
        {
            //Erzeugung eines Arrays typ int größe(10), befüllung mit for-Schleife pro Schleifendurschgang sollen(8er reihe) 
            // Ausgabe über Console
            int[] zahlen = new int[10];
            for (int i = 0; i < zahlen.Length + 1; i++)
            {
                if (i == 0) continue;
                zahlen[i - 1] = 8 * i;
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }


        }
        ////|______________________________________________|
        ////|----------------------------------------------|
        ////|----------------------------------------------|

        private static void BubbleSort(int[] unsortiertesArray)
        {

            int n = unsortiertesArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (unsortiertesArray[j] > unsortiertesArray[j + 1])
                    {
                        int tempVar = unsortiertesArray[j];
                        unsortiertesArray[j] = unsortiertesArray[j + 1];
                        unsortiertesArray[j + 1] = tempVar;
                    }

                }

            }




        }
        ////|______________________________________________|
        ////|----------------------------------------------|
        ////|----------------------------------------------|

        static void Main(string[] args)
        {


            TestArray();
            //Übung arrays 1

            // Erstellen eines int arrys 
            // befüllt wird das array mit einer for loop.
            // das array hat einen max. Index von 100
            // Das array soll mit Zufallszahlen gefüllt werden, die Zahlen müssen durch 2 teilbar sein, es darf keinen Rest geben Anstonsten negative Zufallszahl.
            // Das array soll nach größe der Zahlen sortiert werden. 7,2,1,5 => 1,2,5,7

            int[] zufallsZahlen = new int[10];

            // Startwert 0 Anweisung  
            for (int i = 0; i < zufallsZahlen.Length; i++)
            {
                // ist der Wert durch 2 teilbar?

                //
                int zufallsZahl = _zufallsGenerator.Next(1, 10_000);
                //if ( zufallsZahl % 2 == 0)
                {
                    zufallsZahlen[i] = zufallsZahl;
                }

                //else
                //{
                //    //zufallsZahlen[i] = zufallsZahl * -1;
                //} 
            }


            Console.WriteLine("Vor dem Sortieren");

            foreach (var item in zufallsZahlen)
            {
                Console.WriteLine(item);
            }



            BubbleSort(zufallsZahlen);

            Console.WriteLine("Nach dem Sortieren");

            foreach (var item in zufallsZahlen)
            {
                Console.WriteLine(item);
            }

            ////|______________________________________________|
            ////|----------------------------------------------|
            ////|----------------------------------------------|


            // Sortierung des Arrays

            // BubbleSort ( relativ Einfach aber sehr inperformant) 

            // Varbiablentausch


            int a = 1;
            //int c = antwort
            int b = 2;

            Console.WriteLine(a + " : " + b);

            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " : " + b);

            Console.WriteLine();





            a = b;

            b = a;


            Console.WriteLine(a + " : " + b);


            //int zufallsZahl = _zufallsGenerator.Next(1, 100);



            ////|______________________________________________|
            ////|----------------Übung arrays 1----------------|
            ////|----------------------------------------------|




            //int i = 0;

            string[] piece = new string[4];
            piece[0] = "<";
            piece[1] = "==";
            piece[2] = "3";
            piece[3] = "";
            Console.WriteLine(piece[0] + piece[1] + piece[2] + piece[3]);


            ////|______________________________________________|
            ////|--------------\/Quizfragen\/------------------|
            ////|----------------------------------------------|

            Console.Write("Wie viele Oscars gewann der Film „Titanic“?:");


            Console.ReadLine();
        }
    }
    ////|______________________________________________|
    ////|----------datum und uhrzeit Anzeigen----------|
    ////|----------------------------------------------|

    /// DateTime.Now <-- datum und uhrzeit Anzeigen 
    /// 
    //Console.WriteLine(DateTime.Now + ": " + i + " < " + zahlen.Length + "");
    //Console.WriteLine(i < zahlen.Length);
}