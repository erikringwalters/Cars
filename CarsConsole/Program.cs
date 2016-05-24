using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace CarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carx = new Car();
            carx.set_color("red");
            Console.Out.WriteLine("The color is " + carx.get_color());
            Console.In.ReadLine();
        }
    }
}
