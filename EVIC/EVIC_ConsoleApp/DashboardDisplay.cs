using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVIC_ConsoleApp
{
    public class DashboardDisplay
    {
        private Controller cont;
        private Temperature temp;
        private Odometer odo;
        private Warnings warn;

        // Constructor
        //
        // Pass an instance of a shared controller.
        public DashboardDisplay(Model data)
        {
            cont = new Controller(data);
            temp = new Temperature(data);
            odo = new Odometer(data);
            warn = new Warnings(data);
        }

        // Personal Settings Map
        //
        // Display and handle the personal settings options
        public void PersonalSettingsMap()
        {
            // Display options
            cont.ClearConsole();
            PersonalSettingsOptions();

            // Interpret the user's choice
            try
            {
                // Interpret the user's choice
                ConsoleKeyInfo input = Console.ReadKey();
                int state = cont.GetAction(input);

                // Left arrow is clicked
                if (state == 9)
                {
                    WarningMessagesMap();
                }
                // Up arrow is clicked
                else if (state == 10)
                {
                    PersonalSettingsMap();
                }
                // Right arrow is clicked
                else if (state == 12)
                {
                    TemperatureDisplayMap();
                }
                // Spacebar is clicked
                else if (state == 6)
                {
                    odo.SwitchDistUnits();
                    temp.SwitchDegreeUnits();
                    PersonalSettingsMap();
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        // Personal Settings Options
        //
        // Display the personal settings options
        public void PersonalSettingsOptions()
        {
            // Display the data for the options to output to the user
            List<string> categoryNames = new List<string>()
            {
                "Warning Messages",
                "Units",
                "Temp Info",
                "Toggle Units",
                "System Status"
            };
            List<string> arrowDirs = new List<string>()
            {
                "left",
                "up",
                "right",
                "space",
                "escape"
            };
            SetDisplayOptions(categoryNames, arrowDirs);
        }

        // Read Info
        //
        // Interact with the user to display the information for the program
        public void ReadInfo()
        {
            SystemStatusMap();
            return;
        }

        // Set and Display Options
        //
        // Set and display the user's options for how to proceed
        public void SetDisplayOptions(List<string> categories, List<string> dirs)
        {
            // Get the data for the options to output to the user
            List<List<string>> optionArgs = cont.DisplayOption(categories, dirs);
            int numOptions = optionArgs.Count;
            int numLines = optionArgs[0].Count;

            // Output the options to the user
            for (int i = 0; i < numLines; i++)
            {
                for (int j = 0; j < numOptions; j++)
                {
                    Console.Write(optionArgs[j][i]);
                }
                Console.WriteLine("");
            }
        }

        // System Status Map
        //
        // Display and handle the system status options
        public void SystemStatusMap()
        {
            // Display options
            cont.ClearConsole();
            SystemStatusOptions();

            try
            {
                // Interpret the user's choice
                ConsoleKeyInfo input = Console.ReadKey();
                int state = cont.GetAction(input);

                // Left arrow key pressed
                if (9 == state)
                {
                    TripInfoMap();
                }
                // Up or down arrow key pressed
                else if ((10 == state) || (11 == state))
                {
                    odo.ToggleOdometerSys();
                    SystemStatusMap();
                }
                // Right arrow key pressed
                else if (12 == state)
                {
                    WarningMessagesMap();
                }
                // Spacebar key pressed
                else if (6 == state)
                {
                    odo.ResetOilChangeDist();
                    SystemStatusMap();
                }
                // Escape key pressed
                else if (8 == state)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        // System Status Options
        //
        // Display the system status options
        public void SystemStatusOptions()
        {
            // Display the data for the options to output to the user
            List<string> categoryNames = new List<string>()
            {
                "Trip Info",
                "System Info",
                "Warning Messages",
                "Reset Oil",
                "Quit Display"
            };
            List<string> arrowDirs = new List<string>()
            {
                "left",
                "up&down",
                "right",
                "space",
                "escape"
            };
            SetDisplayOptions(categoryNames, arrowDirs);
        }

        // Temperature Display Map
        //
        // Display and handle the temperature display options
        public void TemperatureDisplayMap()
        {
            // Display options
            cont.ClearConsole();
            TemperatureOptions();

            try
            {
                // Interpret the user's choice
                ConsoleKeyInfo input = Console.ReadKey();
                int state = cont.GetAction(input);

                // Left arrow key pressed
                if (9 == state)
                {
                    PersonalSettingsMap();
                }
                // Up or down arrow key pressed
                else if ((10 == state) || (11 == state))
                {
                    temp.ToggleDisplayTemp();
                    TemperatureDisplayMap();
                }
                // Right arrow key pressed
                else if (12 == state)
                {
                    TripInfoMap();
                }
                // Escape key pressed
                else if (8 == state)
                {
                    SystemStatusMap();
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        // Temperature Options
        //
        // Display the temperature options
        public void TemperatureOptions()
        {
            // Display the data for the options to output to the user
            List<string> categoryNames = new List<string>()
            {
                "Personal Settings",
                "Toggle Temp Info",
                "Trip Info",
                "System Status"
            };
            List<string> arrowDirs = new List<string>()
            {
                "left",
                "up&down",
                "right",
                "escape"
            };
            SetDisplayOptions(categoryNames, arrowDirs);
        }

        // Trip Info Map
        //
        // Display and handle the trip information options
        public void TripInfoMap()
        {
            // Display options
            cont.ClearConsole();
            TripInfoOptions();

            try
            {
                // Interpret the user's choice
                ConsoleKeyInfo input = Console.ReadKey();
                int state = cont.GetAction(input);

                // Left arrow key pressed
                if (9 == state)
                {
                    TemperatureDisplayMap();
                }
                // Up or down arrow key pressed
                else if ((10 == state) || (11 == state))
                {
                    odo.ToggleTripDisp();
                    TripInfoMap();
                }
                // Right arrow key pressed
                else if (12 == state)
                {
                    SystemStatusMap();
                }
                // Spacebar key pressed
                else if (6 == state)
                {
                    odo.ResetCurrentTrip();
                    TripInfoMap();
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        // Trip Info Options
        //
        // Display the trip information options
        public void TripInfoOptions()
        {
            // Display the data for the options to output to the user
            List<string> categoryNames = new List<string>()
            {
                "Temp Info",
                "Toggle Trip Info",
                "System Status",
                "Reset Trip Info"
            };
            List<string> arrowDirs = new List<string>()
            {
                "left",
                "up&down",
                "right",
                "space"
            };
            SetDisplayOptions(categoryNames, arrowDirs);
        }

        // Warning Messages Map
        //
        // Display and handle the warning messages options
        public void WarningMessagesMap()
        {
            // Display options
            cont.ClearConsole();
            WarningMessageOptions();

            try
            {
                // Interpret the user's choice
                ConsoleKeyInfo input = Console.ReadKey();
                int state = cont.GetAction(input);

                // Left arrow key pressed
                if (9 == state)
                {
                    SystemStatusMap();
                }
                // Up arrow key pressed
                else if (10 == state)
                {
                    // Update the warning message state
                    warn.UpdateState();
                    WarningMessagesMap();
                }
                // Right arrow key pressed
                else if (12 == state)
                {
                    PersonalSettingsMap();
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        // Warning Message Options
        //
        // Display the warning message options to the console
        public void WarningMessageOptions()
        {
            // Display the data for the options to output to the user
            List<string> categoryNames = new List<string>()
            {
                "System Status",
                "Warning Messages",
                "Personal Settings"
            };
            List<string> arrowDirs = new List<string>()
            {
                "left",
                "up",
                "right"
            };
            SetDisplayOptions(categoryNames, arrowDirs);
        }
    }
}
