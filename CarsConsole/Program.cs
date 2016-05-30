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
            Program.ListThem();
            //Car carx = new Car();
            //carx.Color = "red";
            //Console.Out.WriteLine("The color is " + carx.Color);
            //Console.In.ReadLine();
        }

        public static void ListThem()
        {
            List<Car> carList = new List<Car>();
            Car carA = new Car();
            carA.Color = "blue";
            carA.TurnOn();
            carA.PressAccelerator();
            carList.Add(carA);
            Car carB = new Car();
            carB.Color = "red";
            carB.TurnOn();
            carB.PressAccelerator(200);
            carList.Add(carB);
            Supercar carC = new Supercar();
            carC.Color = "green";
            carC.TurnOn();
            carC.PressAccelerator(200);
            carList.Add(carC);
            Console.WriteLine("list size is " + carList.Count);
            //Trace.WriteLine("list size is " + carList.Count);
            //Console.ReadLine();
            foreach (Car car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
