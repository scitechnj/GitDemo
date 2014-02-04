using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class MyClass
    {
        //this is a comment
	//really?
        // SETH THATS DISGUSTING!!!!!!!
        private readonly int _x;

        public MyClass(int x)
        {
            _x = x;
        }

        public void PrintX()
        {
            Console.WriteLine(_x);
        }
    }
}
