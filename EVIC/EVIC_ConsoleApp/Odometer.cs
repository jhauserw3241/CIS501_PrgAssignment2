using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVIC_ConsoleApp
{
    public class Odometer
    {
        private Model data;

        // Constructor
        public Odometer(Model d)
        {
            data = d;
        }

        // Convert Distance Types
        //
        // Convert the distance types from US to metric or vice versa
        // @return the specified value in the opposite form it was supplied as
        public double ConvertDistTypes(double value)
        {
            // Determine if the distance type is US or metric
            if (data.IsUsUnits())
            {
                // Convert from US(mi) to metric(km)
                return Math.Round(value * 0.62137);
            }
            else
            {
                // Convert from metric(km) to US(mi)
                return Math.Round(value / 0.62137);
            }
        }

        // Get Current Trip String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the current trip distance
        // @return the string specified above
        public string GetCurrentTripString()
        {
            if (data.IsTripA())
            {
                return GetTripAString();
            }
            else
            {
                return GetTripBString();
            }
        }

        // Get Miles Till Oil Change String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the miles till the next oil change
        // @return the string specified above
        public string GetMilesTillOilChangeString()
        {
            if (data.IsUsUnits())
            {
                return "[Oil change in " + data.GetMilesTillNextChange().ToString() + " mi]";
            }
            else
            {
                return "[Oil change in " + data.GetMilesTillNextChange().ToString() + " km]";
            }
        }

        // Get Odometer String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the odometer
        // @return the string specified above
        public string GetOdometerString()
        {
            if (data.IsUsUnits())
            {
                return "[" + data.GetOdometerValue().ToString() + " mi]";
            }
            else
            {
                return "[" + data.GetOdometerValue().ToString() + " km]";
            }
        }

        // Get System Info String
        //
        // Get a string formatted correctly for this program that
        // contains the either the odometer value or the miles to
        // the next oil change
        // @return the string specified above
        public string GetSysInfoString()
        {
            // Determine whether or not to show the odometer value
            if (data.GetOdometerSys())
            {
                return GetOdometerString();
            }
            else
            {
                return GetMilesTillOilChangeString();
            }
        }

        // Get Trip A String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the Trip A distance
        // @return the string specified above
        public string GetTripAString()
        {
            if (data.IsUsUnits())
            {
                return "[Trip-A: " + data.GetTripADist().ToString() + " mi]";
            }
            else
            {
                return "[Trip-A: " + data.GetTripADist().ToString() + " km]";
            }
        }

        // Get Trip B String
        //
        // Get a string formatted correctly for this program that
        // contains the value of the Trip B distance
        // @return the string specified above
        public string GetTripBString()
        {
            if (data.IsUsUnits())
            {
                return "[Trip-B: " + data.GetTripBDist().ToString() + " mi]";
            }
            else
            {
                return "[Trip-B: " + data.GetTripBDist().ToString() + " km]";
            }
        }

        // Get Unit Type String
        //
        // Get a string formatted correctly for this program that
        // contains the unit type
        // @return the string specified above
        public string GetUnitTypeString()
        {
            if (data.IsUsUnits())
            {
                return "[US Units]";
            }
            else
            {
                return "[Metric Units]";
            }
        }

        // Increment
        //
        // Increment the odometer values
        public void Increment()
        {
            // Incrementation value in US units
            double incrementDist = 1.00;

            // Get one mile worth of kilometers if the units are metric
            if (!data.IsUsUnits())
            {
                incrementDist = ConvertDistTypes(incrementDist);
            }

            // Increment the odometer value
            data.SetOdometerValue(data.GetOdometerValue() + incrementDist);

            // Increment the distance for Trip A
            data.SetTripADist(data.GetTripADist() + incrementDist);

            // Increment the distance for Trip B
            data.SetTripBDist(data.GetTripBDist() + incrementDist);

            // Decrement the miles till the next oil change
            data.SetOilChangeDist(data.GetMilesTillNextChange() - incrementDist);

            // Check if the oil needs to be changed
            if (data.GetMilesTillNextChange() == 0)
            {
                data.SetChangeOil(true);
            }
            else
            {
                data.SetChangeOil(false);
            }
        }

        // Reset Current Trip
        //
        // Reset the current trip distance value
        public void ResetCurrentTrip()
        {
            // Determine if Trip A is the current trip
            if (data.IsTripA())
            {
                ResetTripADist();
            }
            else
            {
                ResetTripBDist();
            }
        }

        // Reset Oil Change Distance
        //
        // Reset the distance to the next oil change
        public void ResetOilChangeDist()
        {
            data.SetOilChangeDist(3000);
        }

        // Reset Trip A Distance
        //
        // Reset the Trip A distance value
        public void ResetTripADist()
        {
            data.SetTripADist(0);
        }

        // Reset Trip B Distance
        //
        // Reset the Trip B distance value
        public void ResetTripBDist()
        {
            data.SetTripBDist(0);
        }

        // Switch Distance Units
        //
        // Switch the units all of the distance values from US
        // to metric units or vice versa
        public void SwitchDistUnits()
        {
            // Set all of the distance values to the opposite units
            data.SetOdometerValue(ConvertDistTypes(data.GetOdometerValue()));
            data.SetOilChangeDist(ConvertDistTypes(data.GetMilesTillNextChange()));
            data.SetTripADist(ConvertDistTypes(data.GetTripADist()));
            data.SetTripBDist(ConvertDistTypes(data.GetTripBDist()));

            // Toggle the US/metric units indicator
            data.SetUsUnits(!data.IsUsUnits());
        }

        // Toggle Change Oil
        //
        // Toggle whether or not the user needs to change the oil
        public void ToggleChangeOil()
        {
            data.SetChangeOil(!data.IsChangeOil());
        }

        // Toggle Odometer System
        //
        // Toggles what is displayed on the System Status screen.
        public void ToggleOdometerSys()
        {
            data.SetOdometerSys(!data.GetOdometerSys());
        }

        // Toggle Trip Display
        //
        // Toggles which trip is displayed.
        public void ToggleTripDisp()
        {
            data.SetTripDisp(!data.IsTripA());
        }
    }
}
