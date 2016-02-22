using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVIC_ConsoleApp
{
    public class Temperature
    {
        private Model data;

        // Constructor
        public Temperature(Model d)
        {
            data = d;
        }

        // Convert Degree Types
        //
        // Convert the degree types from Farenheit to Celcius or vice versa
        // @return the specified value in the opposite form it was supplied as
        public double ConvertDegreeTypes(double value)
        {
            // Determine if the degree type is Farenheit or Celcius
            if (data.IsFarenheitUnits())
            {
                // Convert from Farenheit to Celcius
                return Math.Round(((value - 32.0) / (9.0 / 5.0)), 2);
            }
            else
            {
                // Convert from Farenheit to Celcius
                return Math.Round(((value * (9.0 / 5.0)) + 32.0), 2);
            }
        }

        // Get Current Temperature String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the current temperature
        // @return the string specified above
        public string GetCurrentTempString()
        {
            if (data.IsOutTemp())
            {
                return GetOutTempString();
            }
            else
            {
                return GetInTempString();
            }
        }

        // Get Inside Temperature String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the inside temperature
        // @return the string specified above
        public string GetInTempString()
        {
            if (data.IsFarenheitUnits())
            {
                return "[" + data.GetInTemp().ToString() + " F Inside]";
            }
            else
            {
                return "[" + data.GetInTemp().ToString() + " C Inside]";
            }
        }

        // Get Outside Temperature String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the outside temperature
        // @return the string specified above
        public string GetOutTempString()
        {
            if (data.IsFarenheitUnits())
            {
                return "[" + data.GetOutTemp().ToString() + " F Outside]";
            }
            else
            {
                return "[" + data.GetOutTemp().ToString() + " C Outside]";
            }
        }

        // Set Inside Temperature
        //
        // Set the inside temperature
        public void SetInsideTemp(double val)
        {
            data.SetInTemp(Math.Round(val, 2));
        }

        // Set Outside Temperature
        //
        // Set the outside temperature
        public void SetOutsideTemp(double val)
        {
            data.SetOutTemp(Math.Round(val, 2));
        }

        // Switch Degree Units
        //
        // Switch the units all of the degree values from Farenheit
        // to Celcius units or vice versa
        public void SwitchDegreeUnits()
        {
            // Switch the units of all the degree values
            data.SetInTemp(ConvertDegreeTypes(data.GetInTemp()));
            data.SetOutTemp(ConvertDegreeTypes(data.GetOutTemp()));

            // Toggle the Farenheit/Celcius indicator
            ToggleDegreeUnits();
        }

        // Toggle Degree Units
        //
        // Toggle whether the temperature is in farenheit or celcius
        public void ToggleDegreeUnits()
        {
            data.SetFarenheitUnits(!data.IsFarenheitUnits());
        }

        // Toggle Display Temp
        //
        // Toggle whether or not the display temperature is the outside temperature
        public void ToggleDisplayTemp()
        {
            data.SetDisplayTemp(!data.IsOutTemp());
        }
    }
}
