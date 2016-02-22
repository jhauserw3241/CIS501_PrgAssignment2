using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC_ConsoleApp;

namespace EVIC_Tests
{
    [TestClass]
    public class TemperatureTests
    {
        private static Model data = new Model();
        private Temperature temp = new Temperature(data);

        // Verify Inside Temperature Test 1
        //
        // Verify that the inside temperature matches what it
        // is set to in farenheit
        [TestMethod]
        public void ValidInsideTempTest1()
        {
            temp.SetInsideTemp(1234.12);
            Assert.AreEqual<string>("[1234.12 F Inside]", temp.GetInTempString());
        }

        // Verify Inside Temperature Test 2
        //
        // Verify that the inside temperature matches what it
        // is set to in celcius
        [TestMethod]
        public void ValidInsideTempTest2()
        {
            temp.ToggleDegreeUnits();
            temp.SetInsideTemp(1234.12);
            Assert.AreEqual<string>("[1234.12 C Inside]", temp.GetInTempString());
        }

        [TestMethod]
        public void ValidMetricToggle()
        {
            temp.SwitchDegreeUnits();
        }

        [TestMethod]
        public void ValidTempsC()
        {
            temp.SetOutsideTemp(123.45);
            temp.SetInsideTemp(4);
        }

        [TestMethod]
        public void ValidSwitchUnits()
        {
            temp.SwitchDegreeUnits();
        }
    }
}
