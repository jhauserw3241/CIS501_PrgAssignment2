namespace EVIC_GUIApp
{
    partial class EVICForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempButton = new System.Windows.Forms.Button();
            this.warningsButton = new System.Windows.Forms.Button();
            this.odometerButton = new System.Windows.Forms.Button();
            this.odometerValTextBox = new System.Windows.Forms.TextBox();
            this.odometerValueLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.metricUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.usUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.odometerValueUnits = new System.Windows.Forms.Label();
            this.oilChangeDistLabel = new System.Windows.Forms.Label();
            this.oilChangeDistTextBox = new System.Windows.Forms.TextBox();
            this.oilChangeDistUnitsLabel = new System.Windows.Forms.Label();
            this.tripADistLabel = new System.Windows.Forms.Label();
            this.tripADistTextBox = new System.Windows.Forms.TextBox();
            this.tripADistUnitsLabel = new System.Windows.Forms.Label();
            this.tripBDistLabel = new System.Windows.Forms.Label();
            this.tripBDistTextBox = new System.Windows.Forms.TextBox();
            this.tripBDistUnitsLabel = new System.Windows.Forms.Label();
            this.distToggleUnitsLabel = new System.Windows.Forms.Label();
            this.odometerInfoTitleLabel = new System.Windows.Forms.Label();
            this.warningsTitleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeOilLabel = new System.Windows.Forms.Label();
            this.changeOilOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.checkEngineLabel = new System.Windows.Forms.Label();
            this.checkEngineComboBox = new System.Windows.Forms.ComboBox();
            this.doorAjarLabel = new System.Windows.Forms.Label();
            this.doorAjarComboBox = new System.Windows.Forms.ComboBox();
            this.outTempLabel = new System.Windows.Forms.Label();
            this.tempTitleLabel = new System.Windows.Forms.Label();
            this.outTempTextBox = new System.Windows.Forms.TextBox();
            this.outTempUnitsLabel = new System.Windows.Forms.Label();
            this.inTempLabel = new System.Windows.Forms.Label();
            this.inTempTextBox = new System.Windows.Forms.TextBox();
            this.inTempUnitsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempButton
            // 
            this.tempButton.Location = new System.Drawing.Point(129, 12);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(75, 38);
            this.tempButton.TabIndex = 0;
            this.tempButton.Text = "Temperature Information";
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // warningsButton
            // 
            this.warningsButton.Location = new System.Drawing.Point(255, 12);
            this.warningsButton.Name = "warningsButton";
            this.warningsButton.Size = new System.Drawing.Size(76, 38);
            this.warningsButton.TabIndex = 2;
            this.warningsButton.Text = "Warning Messages";
            this.warningsButton.UseVisualStyleBackColor = true;
            this.warningsButton.Click += new System.EventHandler(this.warningsButton_Click);
            // 
            // odometerButton
            // 
            this.odometerButton.Location = new System.Drawing.Point(12, 12);
            this.odometerButton.Name = "odometerButton";
            this.odometerButton.Size = new System.Drawing.Size(76, 38);
            this.odometerButton.TabIndex = 3;
            this.odometerButton.Text = "Odometer Information";
            this.odometerButton.UseVisualStyleBackColor = true;
            this.odometerButton.Click += new System.EventHandler(this.odometerButton_Click);
            // 
            // odometerValTextBox
            // 
            this.odometerValTextBox.Location = new System.Drawing.Point(144, 90);
            this.odometerValTextBox.Name = "odometerValTextBox";
            this.odometerValTextBox.ReadOnly = true;
            this.odometerValTextBox.Size = new System.Drawing.Size(142, 20);
            this.odometerValTextBox.TabIndex = 4;
            this.odometerValTextBox.Text = "0.00";
            // 
            // odometerValueLabel
            // 
            this.odometerValueLabel.AutoSize = true;
            this.odometerValueLabel.Location = new System.Drawing.Point(13, 93);
            this.odometerValueLabel.Name = "odometerValueLabel";
            this.odometerValueLabel.Size = new System.Drawing.Size(101, 13);
            this.odometerValueLabel.TabIndex = 5;
            this.odometerValueLabel.Text = "Odometer Distance:";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(258, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // metricUnitsRadioButton
            // 
            this.metricUnitsRadioButton.AutoSize = true;
            this.metricUnitsRadioButton.Location = new System.Drawing.Point(17, 231);
            this.metricUnitsRadioButton.Name = "metricUnitsRadioButton";
            this.metricUnitsRadioButton.Size = new System.Drawing.Size(81, 17);
            this.metricUnitsRadioButton.TabIndex = 7;
            this.metricUnitsRadioButton.TabStop = true;
            this.metricUnitsRadioButton.Text = "Metric Units";
            this.metricUnitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // usUnitsRadioButton
            // 
            this.usUnitsRadioButton.AutoSize = true;
            this.usUnitsRadioButton.Location = new System.Drawing.Point(17, 254);
            this.usUnitsRadioButton.Name = "usUnitsRadioButton";
            this.usUnitsRadioButton.Size = new System.Drawing.Size(67, 17);
            this.usUnitsRadioButton.TabIndex = 8;
            this.usUnitsRadioButton.TabStop = true;
            this.usUnitsRadioButton.Text = "US Units";
            this.usUnitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // odometerValueUnits
            // 
            this.odometerValueUnits.AutoSize = true;
            this.odometerValueUnits.Location = new System.Drawing.Point(292, 93);
            this.odometerValueUnits.Name = "odometerValueUnits";
            this.odometerValueUnits.Size = new System.Drawing.Size(17, 13);
            this.odometerValueUnits.TabIndex = 9;
            this.odometerValueUnits.Text = "mi";
            // 
            // oilChangeDistLabel
            // 
            this.oilChangeDistLabel.AutoSize = true;
            this.oilChangeDistLabel.Location = new System.Drawing.Point(14, 127);
            this.oilChangeDistLabel.Name = "oilChangeDistLabel";
            this.oilChangeDistLabel.Size = new System.Drawing.Size(130, 13);
            this.oilChangeDistLabel.TabIndex = 10;
            this.oilChangeDistLabel.Text = "Miles Till Next Oil Change:";
            // 
            // oilChangeDistTextBox
            // 
            this.oilChangeDistTextBox.Location = new System.Drawing.Point(144, 124);
            this.oilChangeDistTextBox.Name = "oilChangeDistTextBox";
            this.oilChangeDistTextBox.ReadOnly = true;
            this.oilChangeDistTextBox.Size = new System.Drawing.Size(142, 20);
            this.oilChangeDistTextBox.TabIndex = 11;
            this.oilChangeDistTextBox.Text = "0.00";
            // 
            // oilChangeDistUnitsLabel
            // 
            this.oilChangeDistUnitsLabel.AutoSize = true;
            this.oilChangeDistUnitsLabel.Location = new System.Drawing.Point(292, 127);
            this.oilChangeDistUnitsLabel.Name = "oilChangeDistUnitsLabel";
            this.oilChangeDistUnitsLabel.Size = new System.Drawing.Size(17, 13);
            this.oilChangeDistUnitsLabel.TabIndex = 12;
            this.oilChangeDistUnitsLabel.Text = "mi";
            // 
            // tripADistLabel
            // 
            this.tripADistLabel.AutoSize = true;
            this.tripADistLabel.Location = new System.Drawing.Point(14, 156);
            this.tripADistLabel.Name = "tripADistLabel";
            this.tripADistLabel.Size = new System.Drawing.Size(83, 13);
            this.tripADistLabel.TabIndex = 13;
            this.tripADistLabel.Text = "Trip A Distance:";
            // 
            // tripADistTextBox
            // 
            this.tripADistTextBox.Location = new System.Drawing.Point(144, 153);
            this.tripADistTextBox.Name = "tripADistTextBox";
            this.tripADistTextBox.ReadOnly = true;
            this.tripADistTextBox.Size = new System.Drawing.Size(142, 20);
            this.tripADistTextBox.TabIndex = 14;
            this.tripADistTextBox.Text = "0.00";
            // 
            // tripADistUnitsLabel
            // 
            this.tripADistUnitsLabel.AutoSize = true;
            this.tripADistUnitsLabel.Location = new System.Drawing.Point(292, 156);
            this.tripADistUnitsLabel.Name = "tripADistUnitsLabel";
            this.tripADistUnitsLabel.Size = new System.Drawing.Size(17, 13);
            this.tripADistUnitsLabel.TabIndex = 15;
            this.tripADistUnitsLabel.Text = "mi";
            // 
            // tripBDistLabel
            // 
            this.tripBDistLabel.AutoSize = true;
            this.tripBDistLabel.Location = new System.Drawing.Point(14, 182);
            this.tripBDistLabel.Name = "tripBDistLabel";
            this.tripBDistLabel.Size = new System.Drawing.Size(83, 13);
            this.tripBDistLabel.TabIndex = 16;
            this.tripBDistLabel.Text = "Trip B Distance:";
            // 
            // tripBDistTextBox
            // 
            this.tripBDistTextBox.Location = new System.Drawing.Point(144, 179);
            this.tripBDistTextBox.Name = "tripBDistTextBox";
            this.tripBDistTextBox.ReadOnly = true;
            this.tripBDistTextBox.Size = new System.Drawing.Size(142, 20);
            this.tripBDistTextBox.TabIndex = 17;
            this.tripBDistTextBox.Text = "0.00";
            // 
            // tripBDistUnitsLabel
            // 
            this.tripBDistUnitsLabel.AutoSize = true;
            this.tripBDistUnitsLabel.Location = new System.Drawing.Point(292, 182);
            this.tripBDistUnitsLabel.Name = "tripBDistUnitsLabel";
            this.tripBDistUnitsLabel.Size = new System.Drawing.Size(17, 13);
            this.tripBDistUnitsLabel.TabIndex = 18;
            this.tripBDistUnitsLabel.Text = "mi";
            // 
            // distToggleUnitsLabel
            // 
            this.distToggleUnitsLabel.AutoSize = true;
            this.distToggleUnitsLabel.Location = new System.Drawing.Point(14, 215);
            this.distToggleUnitsLabel.Name = "distToggleUnitsLabel";
            this.distToggleUnitsLabel.Size = new System.Drawing.Size(70, 13);
            this.distToggleUnitsLabel.TabIndex = 19;
            this.distToggleUnitsLabel.Text = "Toggle Units:";
            // 
            // odometerInfoTitleLabel
            // 
            this.odometerInfoTitleLabel.AutoSize = true;
            this.odometerInfoTitleLabel.Location = new System.Drawing.Point(115, 65);
            this.odometerInfoTitleLabel.Name = "odometerInfoTitleLabel";
            this.odometerInfoTitleLabel.Size = new System.Drawing.Size(108, 13);
            this.odometerInfoTitleLabel.TabIndex = 20;
            this.odometerInfoTitleLabel.Text = "Odometer Information";
            // 
            // warningsTitleLabel
            // 
            this.warningsTitleLabel.AutoSize = true;
            this.warningsTitleLabel.Location = new System.Drawing.Point(115, 65);
            this.warningsTitleLabel.Name = "warningsTitleLabel";
            this.warningsTitleLabel.Size = new System.Drawing.Size(98, 13);
            this.warningsTitleLabel.TabIndex = 21;
            this.warningsTitleLabel.Text = "Warning Messages";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(258, 261);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeOilLabel
            // 
            this.changeOilLabel.AutoSize = true;
            this.changeOilLabel.Location = new System.Drawing.Point(14, 106);
            this.changeOilLabel.Name = "changeOilLabel";
            this.changeOilLabel.Size = new System.Drawing.Size(103, 13);
            this.changeOilLabel.TabIndex = 23;
            this.changeOilLabel.Text = "Need to Change Oil:";
            // 
            // changeOilOptionsComboBox
            // 
            this.changeOilOptionsComboBox.FormattingEnabled = true;
            this.changeOilOptionsComboBox.Location = new System.Drawing.Point(144, 103);
            this.changeOilOptionsComboBox.Name = "changeOilOptionsComboBox";
            this.changeOilOptionsComboBox.Size = new System.Drawing.Size(142, 21);
            this.changeOilOptionsComboBox.TabIndex = 24;
            // 
            // checkEngineLabel
            // 
            this.checkEngineLabel.AutoSize = true;
            this.checkEngineLabel.Location = new System.Drawing.Point(14, 134);
            this.checkEngineLabel.Name = "checkEngineLabel";
            this.checkEngineLabel.Size = new System.Drawing.Size(105, 13);
            this.checkEngineLabel.TabIndex = 25;
            this.checkEngineLabel.Text = "Check Egnine Soon:";
            // 
            // checkEngineComboBox
            // 
            this.checkEngineComboBox.FormattingEnabled = true;
            this.checkEngineComboBox.Location = new System.Drawing.Point(144, 131);
            this.checkEngineComboBox.Name = "checkEngineComboBox";
            this.checkEngineComboBox.Size = new System.Drawing.Size(142, 21);
            this.checkEngineComboBox.TabIndex = 26;
            // 
            // doorAjarLabel
            // 
            this.doorAjarLabel.AutoSize = true;
            this.doorAjarLabel.Location = new System.Drawing.Point(14, 163);
            this.doorAjarLabel.Name = "doorAjarLabel";
            this.doorAjarLabel.Size = new System.Drawing.Size(54, 13);
            this.doorAjarLabel.TabIndex = 27;
            this.doorAjarLabel.Text = "Door Ajar:";
            // 
            // doorAjarComboBox
            // 
            this.doorAjarComboBox.FormattingEnabled = true;
            this.doorAjarComboBox.Location = new System.Drawing.Point(144, 160);
            this.doorAjarComboBox.Name = "doorAjarComboBox";
            this.doorAjarComboBox.Size = new System.Drawing.Size(142, 21);
            this.doorAjarComboBox.TabIndex = 28;
            // 
            // outTempLabel
            // 
            this.outTempLabel.AutoSize = true;
            this.outTempLabel.Location = new System.Drawing.Point(13, 106);
            this.outTempLabel.Name = "outTempLabel";
            this.outTempLabel.Size = new System.Drawing.Size(109, 13);
            this.outTempLabel.TabIndex = 29;
            this.outTempLabel.Text = "Outside Temperature:";
            // 
            // tempTitleLabel
            // 
            this.tempTitleLabel.AutoSize = true;
            this.tempTitleLabel.Location = new System.Drawing.Point(101, 65);
            this.tempTitleLabel.Name = "tempTitleLabel";
            this.tempTitleLabel.Size = new System.Drawing.Size(122, 13);
            this.tempTitleLabel.TabIndex = 30;
            this.tempTitleLabel.Text = "Temperature Information";
            // 
            // outTempTextBox
            // 
            this.outTempTextBox.Location = new System.Drawing.Point(144, 103);
            this.outTempTextBox.Name = "outTempTextBox";
            this.outTempTextBox.ReadOnly = true;
            this.outTempTextBox.Size = new System.Drawing.Size(142, 20);
            this.outTempTextBox.TabIndex = 31;
            this.outTempTextBox.Text = "0.00";
            // 
            // outTempUnitsLabel
            // 
            this.outTempUnitsLabel.AutoSize = true;
            this.outTempUnitsLabel.Location = new System.Drawing.Point(292, 106);
            this.outTempUnitsLabel.Name = "outTempUnitsLabel";
            this.outTempUnitsLabel.Size = new System.Drawing.Size(13, 13);
            this.outTempUnitsLabel.TabIndex = 32;
            this.outTempUnitsLabel.Text = "F";
            // 
            // inTempLabel
            // 
            this.inTempLabel.AutoSize = true;
            this.inTempLabel.Location = new System.Drawing.Point(14, 139);
            this.inTempLabel.Name = "inTempLabel";
            this.inTempLabel.Size = new System.Drawing.Size(101, 13);
            this.inTempLabel.TabIndex = 33;
            this.inTempLabel.Text = "Inside Temperature:";
            // 
            // inTempTextBox
            // 
            this.inTempTextBox.Location = new System.Drawing.Point(144, 136);
            this.inTempTextBox.Name = "inTempTextBox";
            this.inTempTextBox.ReadOnly = true;
            this.inTempTextBox.Size = new System.Drawing.Size(142, 20);
            this.inTempTextBox.TabIndex = 34;
            this.inTempTextBox.Text = "0.00";
            // 
            // inTempUnitsLabel
            // 
            this.inTempUnitsLabel.AutoSize = true;
            this.inTempUnitsLabel.Location = new System.Drawing.Point(292, 139);
            this.inTempUnitsLabel.Name = "inTempUnitsLabel";
            this.inTempUnitsLabel.Size = new System.Drawing.Size(13, 13);
            this.inTempUnitsLabel.TabIndex = 35;
            this.inTempUnitsLabel.Text = "F";
            // 
            // EVICForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 293);
            this.Controls.Add(this.inTempUnitsLabel);
            this.Controls.Add(this.inTempTextBox);
            this.Controls.Add(this.inTempLabel);
            this.Controls.Add(this.outTempUnitsLabel);
            this.Controls.Add(this.outTempTextBox);
            this.Controls.Add(this.tempTitleLabel);
            this.Controls.Add(this.outTempLabel);
            this.Controls.Add(this.doorAjarComboBox);
            this.Controls.Add(this.doorAjarLabel);
            this.Controls.Add(this.checkEngineComboBox);
            this.Controls.Add(this.checkEngineLabel);
            this.Controls.Add(this.changeOilOptionsComboBox);
            this.Controls.Add(this.changeOilLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.warningsTitleLabel);
            this.Controls.Add(this.odometerInfoTitleLabel);
            this.Controls.Add(this.distToggleUnitsLabel);
            this.Controls.Add(this.tripBDistUnitsLabel);
            this.Controls.Add(this.tripBDistTextBox);
            this.Controls.Add(this.tripBDistLabel);
            this.Controls.Add(this.tripADistUnitsLabel);
            this.Controls.Add(this.tripADistTextBox);
            this.Controls.Add(this.tripADistLabel);
            this.Controls.Add(this.oilChangeDistUnitsLabel);
            this.Controls.Add(this.oilChangeDistTextBox);
            this.Controls.Add(this.oilChangeDistLabel);
            this.Controls.Add(this.odometerValueUnits);
            this.Controls.Add(this.usUnitsRadioButton);
            this.Controls.Add(this.metricUnitsRadioButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.odometerValueLabel);
            this.Controls.Add(this.odometerValTextBox);
            this.Controls.Add(this.odometerButton);
            this.Controls.Add(this.warningsButton);
            this.Controls.Add(this.tempButton);
            this.Name = "EVICForm";
            this.Text = "EVIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tempButton;
        private System.Windows.Forms.Button warningsButton;
        private System.Windows.Forms.Button odometerButton;
        private System.Windows.Forms.TextBox odometerValTextBox;
        private System.Windows.Forms.Label odometerValueLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.RadioButton metricUnitsRadioButton;
        private System.Windows.Forms.RadioButton usUnitsRadioButton;
        private System.Windows.Forms.Label odometerValueUnits;
        private System.Windows.Forms.Label oilChangeDistLabel;
        private System.Windows.Forms.TextBox oilChangeDistTextBox;
        private System.Windows.Forms.Label oilChangeDistUnitsLabel;
        private System.Windows.Forms.Label tripADistLabel;
        private System.Windows.Forms.TextBox tripADistTextBox;
        private System.Windows.Forms.Label tripADistUnitsLabel;
        private System.Windows.Forms.Label tripBDistLabel;
        private System.Windows.Forms.TextBox tripBDistTextBox;
        private System.Windows.Forms.Label tripBDistUnitsLabel;
        private System.Windows.Forms.Label distToggleUnitsLabel;
        private System.Windows.Forms.Label odometerInfoTitleLabel;
        private System.Windows.Forms.Label warningsTitleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label changeOilLabel;
        private System.Windows.Forms.ComboBox changeOilOptionsComboBox;
        private System.Windows.Forms.Label checkEngineLabel;
        private System.Windows.Forms.ComboBox checkEngineComboBox;
        private System.Windows.Forms.Label doorAjarLabel;
        private System.Windows.Forms.ComboBox doorAjarComboBox;
        private System.Windows.Forms.Label outTempLabel;
        private System.Windows.Forms.Label tempTitleLabel;
        private System.Windows.Forms.TextBox outTempTextBox;
        private System.Windows.Forms.Label outTempUnitsLabel;
        private System.Windows.Forms.Label inTempLabel;
        private System.Windows.Forms.TextBox inTempTextBox;
        private System.Windows.Forms.Label inTempUnitsLabel;
    }
}

