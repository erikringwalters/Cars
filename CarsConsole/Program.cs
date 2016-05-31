using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using System.Collections;

namespace CarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.StackThem();
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
        public static void StackThem()
        {
            Stack<Car> carStack = new Stack<Car>();
            Car carD = new Car();
            carD.Color = "purple";
            carD.TurnOn();
            carD.PressAccelerator(200);
            carStack.Push(carD);
            Car carE = new Car();
            carE.Color = "pink";
            carE.TurnOn();
            carE.PressAccelerator(50);
            carStack.Push(carE);
            Car carF = new Car();
            carF.Color = "white";
            carF.TurnOn();
            carF.PressAccelerator();
            carStack.Push(carF);
            Console.WriteLine("Stack size is " + carStack.Count);
            for(int ii = 0; ii < 3; ii++)
            {
                var car = carStack.Pop();
                Console.WriteLine(car.ToString());
            }
        }
    }
}
