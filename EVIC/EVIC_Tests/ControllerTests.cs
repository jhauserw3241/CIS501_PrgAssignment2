using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVIC_ConsoleApp;
using EVIC_Library;
using System.Collections.Generic;

namespace EVIC_Tests
{
    [TestClass]
    public class ControllerTests
    {
        // Create an instance of the controller class to test
        private static Model data = new Model();
        private Controller cont = new Controller(data);

        #region InputKeyTests
        // Temp console key objects
        private ConsoleKeyInfo up = new ConsoleKeyInfo(' ', ConsoleKey.UpArrow, false, false, false);
        private ConsoleKeyInfo down = new ConsoleKeyInfo(' ', ConsoleKey.DownArrow, false, false, false);
        private ConsoleKeyInfo left = new ConsoleKeyInfo(' ', ConsoleKey.LeftArrow, false, false, false);
        private ConsoleKeyInfo right = new ConsoleKeyInfo(' ', ConsoleKey.RightArrow, false, false, false);
        private ConsoleKeyInfo space = new ConsoleKeyInfo(' ', ConsoleKey.Spacebar, false, false, false);
        private ConsoleKeyInfo esc = new ConsoleKeyInfo(' ', ConsoleKey.Escape, false, false, false);
        private ConsoleKeyInfo enter = new ConsoleKeyInfo(' ', ConsoleKey.Enter, false, false, false);
        private ConsoleKeyInfo letterA = new ConsoleKeyInfo(' ', ConsoleKey.A, false, false, false);
        private ConsoleKeyInfo letterB = new ConsoleKeyInfo(' ', ConsoleKey.B, false, false, false);
        private ConsoleKeyInfo letterC = new ConsoleKeyInfo(' ', ConsoleKey.C, false, false, false);
        private ConsoleKeyInfo num1 = new ConsoleKeyInfo(' ', ConsoleKey.D1, false, false, false);
        private ConsoleKeyInfo num2 = new ConsoleKeyInfo(' ', ConsoleKey.D2, false, false, false);
        private ConsoleKeyInfo num3 = new ConsoleKeyInfo(' ', ConsoleKey.D3, false, false, false);

        // Valid Down Arrow Input Test
        //
        // Verify that the input from the down arrow key can
        // be read properly
        [TestMethod]
        public void ValidDownArrowInputTest()
        {
            Assert.AreEqual<int>(11, cont.GetAction(down));
        }

        // Valid Enter Input Test
        //
        // Verify that the input from the enter key can
        // be read properly
        [TestMethod]
        public void ValidEnterInputTest()
        {
            Assert.AreEqual<int>(7, cont.GetAction(enter));
        }

        // Valid Escape Input Test
        //
        // Verify that the input from the escape key can
        // be read properly
        [TestMethod]
        public void ValidEscapeInputTest()
        {
            Assert.AreEqual<int>(8, cont.GetAction(esc));
        }

        // Valid Left Arrow Input Test
        //
        // Verify that the input from the left arrow key can
        // be read properly
        [TestMethod]
        public void ValidLeftArrowInputTest()
        {
            Assert.AreEqual<int>(9, cont.GetAction(left));
        }

        // Valid Letter A Input Test
        //
        // Verify that the input from the letter A key can
        // be read properly
        [TestMethod]
        public void ValidLetterAInputTest()
        {
            Assert.AreEqual<int>(3, cont.GetAction(letterA));
        }

        // Valid Letter B Input Test
        //
        // Verify that the input from the letter B key can
        // be read properly
        [TestMethod]
        public void ValidLetterBInputTest()
        {
            Assert.AreEqual<int>(4, cont.GetAction(letterB));
        }

        // Valid Letter C Input Test
        //
        // Verify that the input from the letter C key can
        // be read properly
        [TestMethod]
        public void ValidLetterCInputTest()
        {
            Assert.AreEqual<int>(5, cont.GetAction(letterC));
        }

        // Valid Number 1 Input Test
        //
        // Verify that the input from the number 1 key can
        // be read properly
        [TestMethod]
        public void ValidNumber1InputTest()
        {
            Assert.AreEqual<int>(0, cont.GetAction(num1));
        }

        // Valid Number 2 Input Test
        //
        // Verify that the input from the number 2 key can
        // be read properly
        [TestMethod]
        public void ValidNumber2InputTest()
        {
            Assert.AreEqual<int>(1, cont.GetAction(num2));
        }

        // Valid Number 3 Input Test
        //
        // Verify that the input from the number 3 key can
        // be read properly
        [TestMethod]
        public void ValidNumber3InputTest()
        {
            Assert.AreEqual<int>(2, cont.GetAction(num3));
        }

        // Valid Right Arrow Input Test
        //
        // Verify that the input from the right arrow key can
        // be read properly
        [TestMethod]
        public void ValidRightArrowInputTest()
        {
            Assert.AreEqual<int>(12, cont.GetAction(right));
        }

        // Valid Spacebar Input Test
        //
        // Verify that the input from the spacebar key can
        // be read properly
        [TestMethod]
        public void ValidSpacebarInputTest()
        {
            Assert.AreEqual<int>(6, cont.GetAction(space));
        }

        // Valid Up Arrow Input Test
        //
        // Verify that the input from the up arrow key can
        // be read properly
        [TestMethod]
        public void ValidUpArrowInputTest()
        {
            Assert.AreEqual<int>(10, cont.GetAction(up));
        }
        #endregion

        // Different Size Lists Display Option
        //
        // Test DisplayOption() with the two list arguments being different sizes
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "The number of items in the two parameter lists don't match")]
        public void DifferentSizeListsDisplayOptionTest()
        {
            // Arguments
            List<string> catNames = new List<string>()
                {
                    "cat1"
                };
            List<string> arrowDirs = new List<string>()
                {
                    "a1",
                    "a2"
                };

            cont.DisplayOption(catNames, arrowDirs);
        }

        // Valid Clear Test
        [TestMethod]
        public void ValidClearTest()
        {
            cont.ClearConsole();
        }

        // Valid Display Option
        //
        // Test DisplayOption() with valid arguments
        [TestMethod]
        public void ValidDisplayOptionTest1()
        {
            // Arguments
            List<string> catNames = new List<string>()
                {
                    "cat1",
                    "cat 2"
                };
            List<string> arrowDirs = new List<string>()
                {
                    "a1",
                    "a2"
                };

            cont.DisplayOption(catNames, arrowDirs);
        }

        // Valid Display Option
        //
        // Test DisplayOption() with valid arguments
        [TestMethod]
        public void ValidDisplayOptionTest2()
        {
            // Arguments
            List<string> catNames = new List<string>()
                {
                    "Trip Info",
                    "Warning Messages",
                    "Door Ajar",
                    "Check Engine",
                    "SystemInfo",
                    "Units",
                    "Temp Info"
                };
            List<string> arrowDirs = new List<string>()
                {
                    "left",
                    "up",
                    "up&down",
                    "down",
                    "right",
                    "space",
                    "escape"
                };

            cont.DisplayOption(catNames, arrowDirs);
        }
    }
}
