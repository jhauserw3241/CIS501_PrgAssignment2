using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC;

namespace EVICTests
{
    [TestClass]
    public class WarningTests
    {
        private static Model data = new Model();
        private Warnings warn = new Warnings(data);

        // Verify Change Oil String Test #1
        //
        // Verify that the string to that specifies whether or not
        // the change the oil is accurate according to the default value
        [TestMethod]
        public void VerfiyChangeOilStringTest1()
        {
            Assert.AreEqual<string>("[Oil change: False]", warn.GetChangeOilString());
        }

        // Verify Change Oil String Test #2
        //
        // Verify that the string to that specifies whether or not
        // the change the oil is accurate according to the default value
        [TestMethod]
        public void VerfiyChangeOilStringTest2()
        {
            warn.ToggleChangeOil();
            Assert.AreEqual<string>("[Oil change: True]", warn.GetChangeOilString());
        }

        // Verify Check Engine String Test #1
        //
        // Verify that the string to that specifies whether or not the check
        // engine soon indicator is accurate according to the default value
        [TestMethod]
        public void VerfiyCheckEngineStringTest1()
        {
            Assert.AreEqual<string>("[Check Engine: False]", warn.GetCheckEngineString());
        }

        // Verify Check Engine String Test #2
        //
        // Verify that the string to that specifies whether or not the check
        // engine soon indicator is accurate according to the default value
        [TestMethod]
        public void VerfiyCheckEngineStringTest2()
        {
            warn.ToggleCheckEngine();
            Assert.AreEqual<string>("[Check Engine: True]", warn.GetCheckEngineString());
        }

        // Verify Door Ajar String Test #1
        //
        // Verify that the string to that specifies whether or not the door
        // ajar indicator is accurate according to the default value
        [TestMethod]
        public void VerfiyDoorAjarStringTest1()
        {
            Assert.AreEqual<string>("[Door Ajar: False]", warn.GetDoorAjarString());
        }

        // Verify Door Ajar String Test #2
        //
        // Verify that the string to that specifies whether or not the door
        // ajar indicator is accurate according to the default value
        [TestMethod]
        public void VerfiyDoorAjarStringTest2()
        {
            warn.ToggleDoorAjar();
            Assert.AreEqual<string>("[Door Ajar: True]", warn.GetDoorAjarString());
        }

        // Verify Current Message String Test #1
        //
        // Verify that the message string matches the message string of
        // the second option
        [TestMethod]
        public void VerifyCurrentMessageString1()
        {
            warn.UpdateState();
            Assert.AreEqual<string>("[Check Engine: False]", warn.GetCheckEngineString());
        }

        // Verify Current Message String Test #2
        //
        // Verify that the message string matches the message string of
        // the third option
        [TestMethod]
        public void VerifyCurrentMessageString2()
        {
            warn.UpdateState();
            warn.UpdateState();
            Assert.AreEqual<string>("[Door Ajar: False]", warn.GetDoorAjarString());
        }

        // Verify Update Warning State Test #1
        //
        // Verify that the integer specifies the second possible value for
        // the warning states
        [TestMethod]
        public void VerifyUpdateWarningStateTest1()
        {
            warn.UpdateState();
            Assert.AreEqual<int>(1, data.GetWarningMessageState());
        }

        // Verify Update Warning State Test #2
        //
        // Verify that the integer specifies the trasition between the last
        // and first warning states
        [TestMethod]
        public void VerifyUpdateWarningStateTest2()
        {
            warn.UpdateState();
            warn.UpdateState();
            Assert.AreEqual<int>(2, data.GetWarningMessageState());
            warn.UpdateState();
            Assert.AreEqual<int>(0, data.GetWarningMessageState());
        }
    }
}
