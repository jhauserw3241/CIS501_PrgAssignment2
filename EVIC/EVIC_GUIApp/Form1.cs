using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace EVIC_GUIApp
{
    public partial class EVICForm : Form
    {
        // Define constants
        int ODOMETER_STATE = 0;
        int TEMPERATURE_STATE = 1;
        int WARNINGS_STATE = 2;

        // Declare variables
        int currentState = 0;
        
        // EVIC Form
        //
        // Initialize form
        public EVICForm()
        {
            InitializeComponent();
        }

        // Enable Form Editting
        //
        // Modify te values of the variables on the form
        // to allow/remove editing abilities
        private void EnableFormEditing(bool enable)
        {
            // Determine if the current state is the odometer state
            if (ODOMETER_STATE == currentState)
            {
                odometerValTextBox.ReadOnly = !enable;
                oilChangeDistTextBox.ReadOnly = !enable;
                tripADistTextBox.ReadOnly = !enable;
                tripBDistTextBox.ReadOnly = !enable;
            }
            // Determine if the current state is the temperature state
            else if (TEMPERATURE_STATE == currentState)
            {
                outTempTextBox.ReadOnly = !enable;
                inTempTextBox.ReadOnly = !enable;
            }
            // Determine if the current state is the warning state
            else if (WARNINGS_STATE == currentState)
            {
                // Enable editting for combo boxes
                changeOilOptionsComboBox.AllowDrop = enable;
                checkEngineComboBox.AllowDrop = enable;
                doorAjarComboBox.AllowDrop = enable;
            }
            else
            {
                MessageBox.Show("Error: Invalid state requested");
            }
        }

        // Odometer Button Clicked
        //
        // Handle the actions for the odoemter functionality
        private void odometerButton_Click(object sender, EventArgs e)
        {
            // Update the current state
            currentState = ODOMETER_STATE;

            // Show all the odometer related items
            ShowOdometerObjects(true);

            // Hide all the temperature related items
            ShowTempObjects(false);

            // Hide all the warning message related items
            ShowWarningObjects(false);
        }

        // Edit Button Clicked
        //
        // Allow the user to modify the data values of the current state
        private void editButton_Click(object sender, EventArgs e)
        {
            // Switch the modification buttons
            editButton.Visible = false;
            saveButton.Visible = true;

            // Allow editting
            EnableFormEditing(true);
        }

        // Save Button Clicked
        //
        // Handle the user's desire to modify the data
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Allow editting
            EnableFormEditing(false);
        }

        // Temperature Button Clicked
        //
        // Handle actions when the temperature button is pressed
        private void tempButton_Click(object sender, EventArgs e)
        {
            // Update current state
            currentState = TEMPERATURE_STATE;

            // Hide all the odometer related items
            ShowOdometerObjects(false);

            // Show all the temperature related items
            ShowTempObjects(true);

            // Hide all the warning message related items
            ShowWarningObjects(false);
        }

        // Show Odometer Objects
        //
        // Either show or hide the odometer objects
        private void ShowOdometerObjects(bool show)
        {
            // Update labels visibility
            odometerInfoTitleLabel.Visible = show;
            odometerValueLabel.Visible = show;
            odometerValueUnits.Visible = show;
            oilChangeDistLabel.Visible = show;
            oilChangeDistUnitsLabel.Visible = show;
            tripADistLabel.Visible = show;
            tripADistUnitsLabel.Visible = show;
            tripBDistLabel.Visible = show;
            tripBDistUnitsLabel.Visible = show;

            // Update text box visibility
            odometerValTextBox.Visible = show;
            oilChangeDistTextBox.Visible = show;
            tripADistTextBox.Visible = show;
            tripBDistTextBox.Visible = show;

            // Update radio button visibility
            metricUnitsRadioButton.Visible = show;
            usUnitsRadioButton.Visible = show;

            // Show the combo boxes
            changeOilOptionsComboBox.Show();
            checkEngineComboBox.Show();
            doorAjarComboBox.Show();
        }

        // Show Temperature Objects
        //
        // Either show or hide the temperature objects
        private void ShowTempObjects(bool show)
        {
            // Update label visibility
            tempTitleLabel.Visible = show;
            outTempLabel.Visible = show;
            inTempLabel.Visible = show;
            outTempUnitsLabel.Visible = show;
            inTempUnitsLabel.Visible = show;

            // Update textbox visibility
            outTempTextBox.Visible = show;
            inTempTextBox.Visible = show;
        }

        // Show Warning Objects
        //
        // Either show or hid the warning message objects
        private void ShowWarningObjects(bool show)
        {
            // Update label visibility
            warningsTitleLabel.Visible = show;
            changeOilLabel.Visible = show;
            checkEngineLabel.Visible = show;
            doorAjarLabel.Visible = show;

            // Update combo box visibility
            changeOilOptionsComboBox.Visible = show;
            checkEngineComboBox.Visible = show;
            doorAjarComboBox.Visible = show;
        }

        // Warnings Button Clicked
        //
        // Show all the warning message related items
        private void warningsButton_Click(object sender, EventArgs e)
        {
            // Update the current state
            currentState = WARNINGS_STATE;

            // Hide all the odometer related items
            ShowOdometerObjects(false);

            // Hide all the temperature related items
            ShowTempObjects(false);

            // Show all the warning message related items
            ShowWarningObjects(true);

            // Add options to the combo boxes
            changeOilOptionsComboBox.Items.Add(new ListItem("True"));
            changeOilOptionsComboBox.Items.Add(new ListItem("False"));
            checkEngineComboBox.Items.Add(new ListItem("True"));
            checkEngineComboBox.Items.Add(new ListItem("False"));
            doorAjarComboBox.Items.Add(new ListItem("True"));
            doorAjarComboBox.Items.Add(new ListItem("False"));
        }
    }
}
