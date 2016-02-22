using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC_ConsoleApp;

namespace EVIC_Tests
{
    [TestClass]
    public class OdometerTests
    {
        private static Model data = new Model();
        private Odometer odo = new Odometer(data);

        [TestMethod]
        public void ValidIncrementOdometerTest1()
        {
            data.SetOilChangeDist(120);
            odo.Increment();
        }

        [TestMethod]
        public void ValidRsetCurrentTripDist()
        {
            odo.ResetCurrentTrip();
            odo.ToggleTripDisp();
            odo.ResetCurrentTrip();
        }

        [TestMethod]
        public void ValidOilChange()
        {
            odo.ResetOilChangeDist();
        }
    }
}
