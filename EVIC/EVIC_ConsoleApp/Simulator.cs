using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVIC_Library;

namespace EVIC_ConsoleApp
{
    public class Simulator
    {
        private int menuMem = 0; // 0 = Main Menu, 1 = System Status, 2 = Warning Messages, 3 = Temperature
        private Controller controllerInfo;
        private Odometer odo;
        private Warnings warn;
        private Temperature temp;

        public int MenuMem { get { return menuMem; } }

        // Constructor
        // 
        // Pass in an instance of a shared controller.
        public Simulator(Model data)
        {
            controllerInfo = new Controller(data);
            odo = new Odometer(data);
            warn = new Warnings(data);
            temp = new Temperature(data);
        }

        // Display Main Menu
        // 
        // Displays the choices for the main menu of the simulator.
        public void DisplayMainMenu()
        {
            Console.WriteLine("╔═══╤══════════════════╗");
            Console.WriteLine("║ 1 │ System Status    ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║ 2 │ Warning Messages ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║ 3 │ Temperature      ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║Esc│ Leave Simulator  ║");
            Console.WriteLine("╚═══╧══════════════════╝");
        }

        // Display System Modifier
        // 
        // Display the message indicating how the user can modify the System Status from the simulator.
        public void DisplaySystemMod()
        {
            Console.WriteLine("Press [Enter] to increment the distance one unit in the displayed format (Esc to leave).");
        }

        // Display Warning Menu
        // 
        // Displays the choices for the warning toggle menu of the simulator.
        public void DisplayWarningMenu()
        {
            Console.WriteLine("╔═══╤══════════════════╗");
            Console.WriteLine("║ A │ Door ajar        ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║ B │ Check Engine     ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║ C │ Change Oil       ║");
            Console.WriteLine("╟───┼──────────────────╢");
            Console.WriteLine("║Esc│ Return to Menu   ║");
            Console.WriteLine("╚═══╧══════════════════╝");
        }

        // Display Temperature Menu
        // 
        // Displays the choices for altering the temperature display fromt eh simulator.
        public void DisplayTempMenu()
        {
            Console.WriteLine("╔═══╤═════════════════════╗");
            Console.WriteLine("║ A │ Outside Temperature ║");
            Console.WriteLine("╟───┼─────────────────────╢");
            Console.WriteLine("║ B │ Inside Temperature  ║");
            Console.WriteLine("╟───┼─────────────────────╢");
            Console.WriteLine("║Esc│ Return to Menu      ║");
            Console.WriteLine("╚═══╧═════════════════════╝");
        }

        // Get Temperature
        // 
        // Prompts the user for a new temperature value, returns the original value if an incorrect value is entered.
        public double GetTemp(string location)
        {
            double rtrn;
            Console.Write("Please enter a Fahrenheit value for the {0} temperature: ", location);
            if (Double.TryParse(Console.ReadLine(), out rtrn))
            {
                return rtrn;
            }
            else return 0.00;
        }

        // Main
        //
        // Interact with the user to modify the information for the program
        public void ModifyInfo()
        {
            bool cont;
            int action;

            do
            {
                cont = true;
                Console.Clear();
                Console.WriteLine(controllerInfo.GetCategoryValueString("System Status"));
                switch (menuMem)
                {
                    case 0:
                        DisplayMainMenu();

                        try
                        {
                            // Interpret the user's choice
                            ConsoleKeyInfo input = Console.ReadKey();
                            action = controllerInfo.GetAction(input);
                            switch (action)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    menuMem = action + 1;
                                    break;
                                case 8:
                                    cont = false;
                                    return;
                            }
                            break;
                        }
                        catch (System.InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.ToString());
                            break;
                        }
                    case 1:
                        DisplaySystemMod();

                        try
                        {
                            // Interpret the user's choice
                            ConsoleKeyInfo input = Console.ReadKey();
                            action = controllerInfo.GetAction(input);
                            switch (action)
                            {
                                case 7:
                                    odo.Increment();
                                    break;
                                case 8:
                                    menuMem = 0;
                                    break;
                            }
                            break;
                        }
                        catch (System.InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.ToString());
                            break;
                        }
                    case 2:
                        DisplayWarningMenu();

                        try
                        {
                            // Interpret the user's choice
                            ConsoleKeyInfo input = Console.ReadKey();
                            action = controllerInfo.GetAction(input);
                            switch (action)
                            {
                                case 3:
                                    warn.ToggleDoorAjar();
                                    break;
                                case 4:
                                    warn.ToggleCheckEngine();
                                    break;
                                case 5:
                                    warn.ToggleChangeOil();
                                    break;
                                case 8:
                                    menuMem = 0;
                                    break;
                            }
                            break;
                        }
                        catch (System.InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.ToString());
                            break;
                        }
                    case 3:
                        DisplayTempMenu();

                        try
                        {
                            // Interpret the user's choice
                            ConsoleKeyInfo input = Console.ReadKey();
                            action = controllerInfo.GetAction(input);
                            switch (action)
                            {
                                case 3:
                                    temp.SetOutsideTemp(GetTemp("outside"));
                                    break;
                                case 4:
                                    temp.SetInsideTemp(GetTemp("inside"));
                                    break;
                                case 8:
                                    menuMem = 0;
                                    break;
                            }
                            break;
                        }
                        catch (System.InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.ToString());
                            break;
                        }
                }
            } while (cont);
        } // end ModifyInfo
    }
}
