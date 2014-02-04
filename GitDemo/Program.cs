using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        //seth made some changes :)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadKey(true);
        }
    }
}
