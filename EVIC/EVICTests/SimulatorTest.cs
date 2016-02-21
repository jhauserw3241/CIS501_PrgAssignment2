using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC;

namespace EVICTests
{
    [TestClass]
    public class SimulatorTest
    {
        // Create an instance of the simulator to test.
        private static Model data = new Model();
        private Simulator sim = new Simulator(data);

        // Test Main Menu Display
        // 
        // Test if the main menu properly displays
        [TestMethod]
        public void TestMainMenuDisplay()
        {
            sim.DisplayMainMenu();
        }

        // Test System Modifier Display
        // 
        // Test if the System Modifier Screen properly displays.
        [TestMethod]
        public void TestSystemModDisplay()
        {
            sim.DisplaySystemMod();
        }

        // Test Temperature Display
        // 
        // Test if the Temperature Screen properly displays.
        [TestMethod]
        public void TestTemperatureDisplay()
        {
            sim.DisplayTempMenu();
        }

        // Test Warning Menu Display
        // 
        // Test if the warning Menu Screen displays properly.
        [TestMethod]
        public void TestWarningMenuDisplay()
        {
            sim.DisplayWarningMenu();
        }
    }
}
