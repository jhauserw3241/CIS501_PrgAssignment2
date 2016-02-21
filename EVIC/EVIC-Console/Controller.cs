using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVIC;

namespace EVIC
{
    public class Controller
    {
        private Odometer odo;
        private Temperature temp;
        private Warnings warn;

        // Constructor
        public Controller(Model data)
        {
            odo = new Odometer(data);
            temp = new Temperature(data);
            warn = new Warnings(data);
        }

        // Clear Console
        //
        // Clear the console of all text
        public void ClearConsole()
        {
            try
            {
                Console.Clear();
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // Display Option
        //
        // @param categoryName A list of names of the category options presented
        //      to the user
        // @param arrowDir A list of arrow directions for the various category options
        // @return the string array for the option information
        public List<List<string>> DisplayOption(List<string> categoryName, List<string> arrowDir)
        {
            // Define variables
            List<List<string>> totalOutput = new List<List<string>>();
            List<string> output = new List<string>();
            int displayLength = 0;

            // Verify that the number of category names and arrow directions are the same
            if (categoryName.Count != arrowDir.Count)
            {
                throw new ArgumentException("Parameter lists not same size");
            }

            // Add the information for all of the options
            for (int i = 0; i < categoryName.Count; i++)
            {
                output = new List<string>();

                // Get the value to be outputted
                string categoryValue = GetCategoryValueString(categoryName[i]);

                // Determine the length of the option display
                if (displayLength < categoryName[i].Length)
                {
                    displayLength = categoryName[i].Length;
                }
                if (displayLength < categoryValue.Length)
                {
                    displayLength = categoryValue.Length;
                }
                // Verify that the display length is larger than the length of the word "error"
                if (displayLength < 5)
                {
                    displayLength = 5;
                }

                // Create boundary
                string topBottomBoundary = new String('-', (displayLength + 2));
                string intermediateLine = new String(' ', displayLength);
                string categoryNameBuffer = new String(' ', (displayLength - categoryName[i].Length));
                string categoryValueBuffer = new String(' ', (displayLength - categoryValue.Length));

                // Get the arrow lines
                List<string> arrowOutput = GetArrowDirectionStrings(arrowDir[i], displayLength);

                // Add the lines to the display array
                output.Add(topBottomBoundary);
                output.Add("|" + categoryNameBuffer + categoryName[i] + "|");
                output.Add("|" + categoryValueBuffer + categoryValue + "|");
                for (int j = 0; j < arrowOutput.Count; j++)
                {
                    output.Add(arrowOutput[j]);
                }
                output.Add(topBottomBoundary);
                output.Add(" " + intermediateLine + " ");
                totalOutput.Add(output);

                // Reset variables
                displayLength = 0;
            }

            return totalOutput;
        } // End DisplayOption()

        // Get Action
        // 
        // Translates keyboard input into a standard numerical value
        // recognized throughout this class.
        public int GetAction(ConsoleKeyInfo keyInfo)
        {
            try
            {
                //ConsoleKey input = Console.ReadKey().Key;
                switch (keyInfo.Key)
                {
                    // The nuber one key
                    case ConsoleKey.D1:
                        return 0;
                    // The number two key
                    case ConsoleKey.D2:
                        return 1;
                    // The number three key
                    case ConsoleKey.D3:
                        return 2;
                    // The letter A key
                    case ConsoleKey.A:
                        return 3;
                    // The letter B key
                    case ConsoleKey.B:
                        return 4;
                    // The letter C key
                    case ConsoleKey.C:
                        return 5;
                    // The spacebar key
                    case ConsoleKey.Spacebar:
                        return 6;
                    // The enter key
                    case ConsoleKey.Enter:
                        return 7;
                    // The escape key
                    case ConsoleKey.Escape:
                        return 8;
                    // The left arrow key
                    case ConsoleKey.LeftArrow:
                        return 9;
                    // The up arrow key
                    case ConsoleKey.UpArrow:
                        return 10;
                    // The down arrow key
                    case ConsoleKey.DownArrow:
                        return 11;
                    // The right arrow key
                    case ConsoleKey.RightArrow:
                        return 12;
                    default:
                        return -1;
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        // Get Arrow Direction Strings
        //
        // Get the strings that will tell the user which key they need to press to
        // achieve the desired operation
        private List<string> GetArrowDirectionStrings(string arrowDir, int length)
        {
            // Define variables
            List<string> output = new List<string>();
            string intermediateLine = new String(' ', length);
            string sidewaysArrowIntermediate = new String(' ', (length - 2));
            string uprightArrowIntermediate = new String(' ', (length - 1));
            string upDownArrowIntermediate = new String(' ', (length - 2));
            string errorIntermediate = new String(' ', (length - 5));
            string escapeIntermediate = new String(' ', (length - 3));
            string spaceIntermediate = new String(' ', (length - 5));

            if (arrowDir == "left")
            {
                output.Add("|" + intermediateLine + "|");
                output.Add("|" + sidewaysArrowIntermediate + "<-|");
            }
            else if (arrowDir == "up")
            {
                output.Add("|" + uprightArrowIntermediate + "^|");
                output.Add("|" + uprightArrowIntermediate + "||");
            }
            else if (arrowDir == "right")
            {
                output.Add("|" + intermediateLine + "|");
                output.Add("|" + sidewaysArrowIntermediate + "->|");
            }
            else if (arrowDir == "down")
            {
                output.Add("|" + uprightArrowIntermediate + "||");
                output.Add("|" + uprightArrowIntermediate + "v|");
            }
            else if (arrowDir == "up&down")
            {
                output.Add("|" + upDownArrowIntermediate + "^||");
                output.Add("|" + upDownArrowIntermediate + "|v|");
            }
            else if (arrowDir == "escape")
            {
                output.Add("|" + intermediateLine + "|");
                output.Add("|" + escapeIntermediate + "Esc|");
            }
            else if (arrowDir == "space")
            {
                output.Add("|" + intermediateLine + "|");
                output.Add("|" + spaceIntermediate + "space|");
            }
            else
            {
                output.Add("|" + intermediateLine + "|");
                output.Add("|" + errorIntermediate + "error|");
            }

            return output;
        } // End GetArrowDirectionStrings()

        // Get Category Value String
        //
        // Get the category value string that correlates with the
        // category name
        public string GetCategoryValueString(string categoryName)
        {
            if (categoryName.Equals("System Status"))
            {
                return odo.GetOdometerString();
            }
            else if (categoryName.Equals("Door Ajar"))
            {
                return warn.GetDoorAjarString();
            }
            else if (categoryName.Equals("Check Engine"))
            {
                return warn.GetCheckEngineString();
            }
            else if (categoryName.Equals("System Info"))
            {
                return odo.GetSysInfoString();
            }
            else if (categoryName.Equals("Units"))
            {
                return odo.GetUnitTypeString();
            }
            else if (categoryName.Equals("Temp Info") || categoryName.Equals("Toggle Temp Info"))
            {
                return temp.GetCurrentTempString();
            }
            else if (categoryName.Equals("Trip Info") || categoryName.Equals("Toggle Trip Info"))
            {
                return odo.GetCurrentTripString();
            }
            else if (categoryName.Equals("Warning Messages"))
            {
                return warn.GetCurrentMessageString();
            }
            else
            {
                // Create a string full of spaces as a place holder
                return new String(' ', categoryName.Length);
            }
        } // End GetCategoryValueString()
    }
}
