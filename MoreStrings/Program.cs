using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String stores = "Goal" + "Yawn";
            Console.WriteLine(stores.Contains("Y"));
            // STRING METHODS 
            //Contain, checks character existense in a string, \n next line, Length number of characters contained by a string, ToUpper,ToLower

            Console.WriteLine(stores[0]);
            // letter position, index position

            Console.WriteLine(stores.IndexOf('Y'));
            // Shows where a word starts
            Console.WriteLine(stores.Substring(5));
            Console.WriteLine(stores.Substring())
            // gives one part of a string


            Console.ReadLine();
        }
    }
}
