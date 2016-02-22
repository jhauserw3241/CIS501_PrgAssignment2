//using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EVIC_ConsoleApp;
//using EVIC_Tests;
using EVIC_ConsoleApp;


namespace EVIC_Tests
{
    [TestClass]
    public class ModelTests
    {
        //Create an instance of the model class to test
        private Model data = new Model();

        // Valid Check Engine Test
        //
        // Verify that the check engine value getter returns
        // what the value is set to
        [TestMethod]
        public void ValidCheckEngineTest()
        {
            data.SetCheckEngine(false);
            Assert.IsFalse(data.IsCheckEngine());
        }

        // Valid Check Oil Test
        //
        // Verify that the check oil value getter returns what
        // the value is set to
        [TestMethod]
        public void ValidCheckOilTest()
        {
            data.SetChangeOil(true);
            Assert.IsTrue(data.IsChangeOil());
        }

        // Valid Display Temp Test
        //
        // Test whether or not he temperature to display is the outside temperature
        [TestMethod]
        public void ValidDisplayTempTest()
        {
            data.SetDisplayTemp(true);
            Assert.IsTrue(data.IsOutTemp());
        }

        // Valid Display Trip Test
        //
        // Verify the correct trip is being displayed
        [TestMethod]
        public void ValidDisplayTripTest()
        {
            data.SetTripDisp(false);
            Assert.IsFalse(data.IsTripA());
        }

        // Valid Door Ajar Test
        //
        // Verify that the door ajar value getter returns what
        // the value is set to
        [TestMethod]
        public void ValidDoorAjarTest()
        {
            data.SetDoorAjar(true);
            Assert.IsTrue(data.IsDoorAjar());
        }

        // Valid In Temp Test
        //
        // Verify that the internal car temperature is what is specified
        [TestMethod]
        public void ValidInTempTest()
        {
            data.SetInTemp(234.0123);
            Assert.AreEqual(234.0123, data.GetInTemp());
        }

        // Valid Oil Change Dist Test
        //
        // Verify that the number of miles till the next oil change is what is specified
        [TestMethod]
        public void ValidOilChangeDistTest()
        {
            data.SetOilChangeDist(821364834);
            Assert.AreEqual(821364834, data.GetMilesTillNextChange());
        }


        // Valid Odometer System Test
        [TestMethod]
        public void ValidOdometerSystemTest()
        {
            data.SetOdometerSys(true);
            Assert.IsTrue(data.GetOdometerSys());
        }

        [TestMethod]
        public void ValidOutTemp()
        {
            data.SetOutTemp(932471.123434);
            Assert.AreEqual(932471.123434, data.GetOutTemp());
        }

        [TestMethod]
        public void ValidTripADist()
        {
            data.SetTripADist(2900);
            Assert.AreEqual(2900, data.GetTripADist());
        }

        [TestMethod]
        public void ValidTripBDist()
        {
            data.SetTripBDist(12);
            Assert.AreEqual(12, data.GetTripBDist());
        }

        [TestMethod]
        public void ValidWarningMessageState()
        {
            data.SetWarningMessageState(2);
            Assert.AreEqual(2, data.GetWarningMessageState());
        }

        [TestMethod]
        public void ValidOdometerVal()
        {
            data.SetOdometerValue(123);
            Assert.AreEqual(123, data.GetOdometerValue());
        }

        [TestMethod]
        public void ValidMetricUnits()
        {
            data.SetUsUnits(true);
            Assert.IsTrue(data.IsUsUnits());
        }

        [TestMethod]
        public void ValidFarenheitUnits()
        {
            data.SetFarenheitUnits(false);
            Assert.IsFalse(data.IsFarenheitUnits());
        }
    }
}
