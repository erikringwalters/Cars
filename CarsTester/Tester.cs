using Cars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            testcar.TurnCarOn();
            Assert.IsTrue(testcar.engineStatus() == true);
            testcar2.TurnCarOn();
            Assert.IsTrue(testcar2.engineStatus() == true);
            testcar.TurnCarOff();
            Assert.IsTrue(testcar.engineStatus() == false);

        }
        [TestMethod]
        public void EngineOnOrOffTest()
        {
            Car onoroff = new Car();
            onoroff.TurnCarOn();
            Assert.IsTrue(onoroff.GetReport().Status == Status.EngineOn);
            onoroff.TurnCarOff();
            Assert.IsTrue(onoroff.GetReport().Status == Status.EngineOff);
        }
        [TestMethod]
        public void MovingTest()
        {
            Car moving = new Car();
            moving.TurnCarOn();
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
            speedCheck.TurnCarOn();
            speedCheck.PressAccelerator(60);
            Assert.IsTrue(speedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(speedCheck.GetReport().CurrentSpeed == 60);
        }
        [TestMethod]
        public void CheckOverSpeed()
        {
            Car speedCheck = new Car();
            speedCheck.TurnCarOn();
            speedCheck.PressAccelerator(120);
            Assert.IsTrue(speedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(speedCheck.GetReport().CurrentSpeed == 100);
        }
        [TestMethod]
        public void CheckSupercarSpeed()
        {
            Supercar superSpeedCheck = new Supercar();
            superSpeedCheck.TurnCarOn();
            superSpeedCheck.PressAccelerator(230);
            Assert.IsTrue(superSpeedCheck.GetReport().Status == Status.Moving);
            Assert.IsTrue(superSpeedCheck.GetReport().CurrentSpeed == 200);
            superSpeedCheck.PressAccelerator();
            Assert.IsTrue(superSpeedCheck.GetReport().CurrentSpeed == 30);
        }
    }
}
