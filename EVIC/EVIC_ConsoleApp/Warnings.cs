using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVIC_ConsoleApp
{
    public class Warnings
    {
        private Model data;

        // Constructor
        public Warnings(Model d)
        {
            data = d;
        }

        // Get Change Oil String
        //
        // Get a string formatted correctly for this program of
        // whether or not the oil needs to be changed
        // @return the string specified above
        public string GetChangeOilString()
        {
            return "[Oil change: " + data.IsChangeOil().ToString() + "]";
        }

        // Get Check Engine String
        //
        // Get a string formatted correctly for this program of
        // whether or not the engine needs to be checked
        // @return the string specified above
        public string GetCheckEngineString()
        {
            return "[Check Engine: " + data.IsCheckEngine().ToString() + "]";
        }

        // Get Current Message String
        //
        // Get a string formatted correctly for this program of
        // the current warning message
        // @return the string specified above
        public string GetCurrentMessageString()
        {
            if (data.GetWarningMessageState() == 0)
            {
                return GetDoorAjarString();
            }
            else if (data.GetWarningMessageState() == 1)
            {
                return GetCheckEngineString();
            }
            else if (data.GetWarningMessageState() == 2)
            {
                return GetChangeOilString();
            }
            else
            {
                return "Error";
            }
        }

        // Get Door Ajar String
        //
        // Get a string formatted correctly for this program of
        // whether or not the door is open
        // @return the string specified above
        public string GetDoorAjarString()
        {
            return "[Door Ajar: " + data.IsDoorAjar().ToString() + "]";
        }

        // Toggle Change Oil
        //
        // Toggle whether or not the user needs to change the oil
        public void ToggleChangeOil()
        {
            data.SetChangeOil(!data.IsChangeOil());
        }

        // Toggle Check Engine
        //
        // Toggle whether or not the user should check the engine
        public void ToggleCheckEngine()
        {
            data.SetCheckEngine(!data.IsCheckEngine());
        }

        // Toggle Door Ajar
        //
        // Toggle whether or not the door is ajar
        public void ToggleDoorAjar()
        {
            data.SetDoorAjar(!data.IsDoorAjar());
        }

        // Update Type
        //
        // Move the warning message state to the next state
        public void UpdateState()
        {
            data.SetWarningMessageState(data.GetWarningMessageState() + 1);
        }
    }
}
