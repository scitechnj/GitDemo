using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class MyClass
    {

	//really?
        // why did you remove it?
	//hello
        private readonly int _x;

        

        public MyClass(int x)
        {
            _x = x;
        }

        public void PrintX()
        {
            Console.WriteLine(_x);
        }

        public void PrintX2()
        {
            Console.WriteLine(_x*2);
        }

        public void DeleteSethsChanges()
        {
            DeleteSethsChanges();
        }


    }
}
