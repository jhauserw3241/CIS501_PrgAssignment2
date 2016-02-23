using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC_ConsoleApp;
using EVIC_Library;

namespace EVIC_Tests
{
    [TestClass]
    public class OdometerTests
    {
        private static Model data = new Model();
        private Odometer odo = new Odometer(data);

        // Valid Increment Odometer Test #1
        //
        // Verify that the odometer 
        [TestMethod]
        public void ValidIncrementOdometerTest1()
        {
            double incrementVal;

            // Get original variables
            double oldOdoDist = data.GetOdometerValue();
            double oldTripADist = data.GetTripADist();
            double oldTripBDist = data.GetTripBDist();
            double oldOilChangeDist = data.GetMilesTillNextChange();

            // Get incremental value
            if (data.IsUsUnits())
            {
                incrementVal = 1.00;
            }
            else
            {
                incrementVal = 1.60934;
            }

            // Increment
            odo.Increment();

            // Verify that the new variables are correct
            double newOdoDist = data.GetOdometerValue();
            double newTripADist = data.GetTripADist();
            double newTripBDist = data.GetTripBDist();
            double newOilChangeDist = data.GetMilesTillNextChange();

            Assert.AreEqual<double>((oldOdoDist + incrementVal), newOdoDist);
            Assert.AreEqual<double>((oldTripADist + incrementVal), newTripADist);
            Assert.AreEqual<double>((oldTripBDist + incrementVal), newTripBDist);
            Assert.AreEqual<double>((oldOilChangeDist - incrementVal), newOilChangeDist);
        }

        // Valid Reset Current Trip Dist Test #1
        //
        // Verify that the Trip A distance will reset if Trip A is
        // the current trip
        [TestMethod]
        public void ValidResetCurrentTripDistTest1()
        {
            odo.ResetCurrentTrip();
            Assert.AreEqual<double>(0, data.GetTripADist());
        }

        // Valid Reset Current Trip Dist Test #2
        //
        // Verify that the Trip B distance will reset if Trip A is
        // the current trip
        [TestMethod]
        public void ValidResetCurrentTripDistTest2()
        {
            odo.ToggleTripDisp();
            odo.ResetCurrentTrip();
            Assert.AreEqual<double>(0, data.GetTripADist());
        }

        // Valid Oil Change Test
        //
        // Verify that the distance to the next oil change can be reset
        [TestMethod]
        public void ValidOilChange()
        {
            odo.ResetOilChangeDist();
        }
    }
}
