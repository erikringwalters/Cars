using Cars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CarsTester
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void ColorTest()
        {
            Car testcar = new Car();
            testcar.Color = "blue";
            Assert.IsTrue(testcar.Color == "blue");
        }
        [TestMethod]
        public void EngineTest()
        {
            Car testcar = new Car();
            Car testcar2 = new Car();
            testcar.Color = "blue";
            testcar2.Color = "red";
            testcar.TurnOn();
            Assert.IsTrue(testcar.engineStatus() == true);
            testcar2.TurnOn();
            Assert.IsTrue(testcar2.engineStatus() == true);
            testcar.TurnOff();
            Assert.IsTrue(testcar.engineStatus() == false);

        }
        [TestMethod]
        public void EngineOnOrOffTest()
        {
            Car onoroff = new Car();
            onoroff.TurnOn();
            Assert.IsTrue(onoroff.GetReport().Status == Status.EngineOn);
            onoroff.TurnOff();
            Assert.IsTrue(onoroff.GetReport().Status == Status.EngineOff);
        }
        [TestMethod]
        public void MovingTest()
        {
            Car moving = new Car();
            moving.TurnOn();
            moving.PressAccelerator();
            Report r = moving.GetReport();
            Assert.IsTrue(r.Status == Status.Moving);
            moving.PressBrake();
            r = moving.GetReport();
            Assert.IsTrue(r.Status == Status.Stopped);
        }
        [TestMethod]
        public void AccellerateBeforeTurningOnEngineTest()
        {
            Car moving = new Car();
            //moving.TurnCarOn();
            moving.PressAccelerator();
            Assert.IsTrue(moving.GetReport().Status == Status.EngineOff);
        }
        [TestMethod]
        public void CheckSpeed()
        {
            Car speedCheck = new Car();
            speedCheck.TurnOn();
            speedCheck.PressAccelerator(60);
            Assert.IsTrue(speedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(speedCheck.GetReport().CurrentSpeed == 60);
        }
        [TestMethod]
        public void CheckOverSpeed()
        {
            Car speedCheck = new Car();
            speedCheck.TurnOn();
            speedCheck.PressAccelerator(120);
            Assert.IsTrue(speedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(speedCheck.GetReport().CurrentSpeed == 100);
        }
        [TestMethod]
        public void CheckSupercarSpeed()
        {
            Supercar superSpeedCheck = new Supercar();
            superSpeedCheck.TurnOn();
            superSpeedCheck.PressAccelerator(230);
            Assert.IsTrue(superSpeedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(superSpeedCheck.GetReport().CurrentSpeed == 200);
            superSpeedCheck.PressAccelerator();
            Assert.IsTrue(superSpeedCheck.GetReport().CurrentSpeed == 30);
        }
        [TestMethod]
        public void ListThem()
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
            Trace.WriteLine("list size is " + carList.Count);
        }
        [TestMethod]
        public void StackThem();
        
            
        
    }
}
