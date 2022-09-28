using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    ////|______________________________________________|
    ////|--------------zufällige_nummern---------------|
    ////|----------------------------------------------|
namespace zufällige_nummern
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zufällige Nummer: ");
            Random rnd = new Random();
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd.Next());

                Console.ReadLine();
            }
        }
    }
}
