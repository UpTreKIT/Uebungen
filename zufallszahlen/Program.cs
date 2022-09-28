using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


////|______________________________________________|
////|--------------zahlenreihe---------------------|
////|----------------------------------------------|
///
namespace zahlenreihe
{
    public class Program2
    {
        static void Main(string[] args)
        {
            TestArray();
            

        }
        private static Random zahlenreihe = new Random();

        public static void TestArray()
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
            Console.ReadLine();

        }
    }
}