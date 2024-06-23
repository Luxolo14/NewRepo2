using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Container that we can stores values
            //Assigned and declared

            String characterName = "John";

            int characterAge = 35;
            Console.WriteLine("There once was a man named " +characterName);

            Console.WriteLine("He was " + characterAge +" years old ");
            Console.WriteLine("He really liked the name " +characterName);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
