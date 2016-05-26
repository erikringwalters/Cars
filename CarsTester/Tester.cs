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
    }
}
