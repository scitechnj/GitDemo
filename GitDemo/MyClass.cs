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
        // why did you remove it?

        <div class="row">
    <div class="panel panel-info form-group">
        <form role="form">
            <div class="panel-heading"><h3>COMPANY</h3></div>
            <div class="panel-body">
                <div class="col-sm-6 col-md-4">
                    <label for="CoName">Name</label>
                    <input type="text" class="form-control" name="CoName" value="@company.CoName" disabled/>
                </div>
                <div class="col-sm-6 col-md-4">
                    <label for="CoDateAdded">Date Added</label>
                    <input type="text" class="form-control" name="CoDateAdded" value="@company.CoDateAdded" disabled />
                </div>
                <div class="col-sm-6 col-md-4">
                    <label for="CoStreet">Street</label>
                    <input type="text" class="form-control" name="CoStreet" value="@company.CoStreet" disabled />
                </div>
            </div>
        </form>
    </div>

	//moar stuf
        private readonly int _x;

        public static void QuickEscalation()
        {
            Console.WriteLine("Yedid doesn't like this method!!");
            Console.WriteLine("Humanity does not ask us to be happy. It merely asks us to be brilliant on its behalf");

        }

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
