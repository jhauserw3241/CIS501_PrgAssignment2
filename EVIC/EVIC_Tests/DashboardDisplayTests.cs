using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC_ConsoleApp;
using EVIC_Library;
using System.Collections.Generic;

namespace EVIC_Tests
{
    [TestClass]
    public class DashboardDisplayTests
    {
        private static Model data = new Model();
        private DashboardDisplay dash = new DashboardDisplay(data);

        #region DisplayOptions
        // Valid Personal Settings Options Test
        //
        // Verify that the Personal Settings options can be ouputted to
        // the console
        [TestMethod]
        public void ValidPersonalSettingsOptionsTest()
        {
            dash.PersonalSettingsOptions();
        }

        // Valid System Status Options Test
        //
        // Verify that the System Status options can be ouputted to
        // the console
        [TestMethod]
        public void ValidSystemStatusOptionsTest()
        {
            dash.SystemStatusOptions();
        }

        // Valid Temperature Options Test
        //
        // Verify that the Temperature options can be ouputted to
        // the console
        [TestMethod]
        public void ValidTempOptionsTest()
        {
            dash.TemperatureOptions();
        }

        // Valid Trip Information Options Test
        //
        // Verify that the Trip Info options can be ouputted to
        // the console
        [TestMethod]
        public void ValidTripInfoOptionsTest()
        {
            dash.TripInfoOptions();
        }

        // Valid Warning Message Options Test
        //
        // Verify that the Warning Message options can be ouputted to
        // the console
        [TestMethod]
        public void ValidWarningMessageOptionsTest()
        {
            dash.TripInfoOptions();
        }
        #endregion

        // Valid Set Display Options Test
        //
        // Verify that the set display option can output text to
        // the console
        [TestMethod]
        public void ValidSetDisplayOptions()
        {
            List<string> exmp1 = new List<string>()
                {
                    "System Status",
                    "Trip Info"
                };

            List<string> exmp2 = new List<string>()
                {
                    "left",
                    "right"
                };

            dash.SetDisplayOptions(exmp1, exmp2);
        }
    }
}
