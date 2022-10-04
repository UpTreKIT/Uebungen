using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

////|______________________________________________|
////|-------------------String---------------------|
////|----------------------------------------------|
namespace String
{
    internal class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {

            string s = "Penis";                                                                     //>
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);      //  Text mittisch ausgeben (z.B.: als überschrift)
            Console.WriteLine(s);                                                                      //>

            string[] emoji = new string[3];

            emoji[0] = "8";
            emoji[1] = "==";
            emoji[2] = ">";

            Console.WriteLine(emoji[0] + emoji[1] + emoji[2]);

            Console.ReadLine();

        }
    }
}