using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVIC_Library;

namespace EVIC_ConsoleApp
{
    public class Program
    {
        private static Model data = new Model();
        private DashboardDisplay display = new DashboardDisplay(data);
        private Simulator sim = new Simulator(data);
        private static Controller cont = new Controller(data);

        // Main
        //
        // Main functionality for program to start at
        static void Main()
        {
            Program currentProgram = new Program();
            int status = 0;
            while (status == 0)
            {
                cont.ClearConsole();
                status = currentProgram.ProvideUserOptions();
            }
        }

        // Provide User Options
        //
        // Provider the user the option of using the Dashboard
        // Display or the Simulator
        public int ProvideUserOptions()
        {
            // Offer the user option
            Console.WriteLine("Which program would you like to use?(1, 2, or 3)");
            Console.WriteLine("1.) Dashboard Display");
            Console.WriteLine("2.) Simulator");
            Console.WriteLine("3.) Quit Program");

            string input = Console.ReadLine();

            // Interpret the user's choice
            if (input.Equals("1"))
            {
                display.ReadInfo();
                return 0;
            }
            else if (input.Equals("2"))
            {
                sim.ModifyInfo();
                return 0;
            }
            else if (input.Equals("3"))
            {
                return 1;
            }
            else
            {
                Console.Write("Error: Invalid option");
                return 0;
            }
        }
    }
}
