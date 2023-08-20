namespace Koshary_Architecture.UI_Forms
{
    partial class Example_3
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
            SkillsDropDown = new ListBox();
            ErrorsMessageLabel = new Label();
            SuccessMessageLabel = new Label();
            AddNewEmployeeButton = new Button();
            EmployeeSkillsLabel = new Label();
            StreetAndBuildingNumberLabel = new Label();
            CityLabel = new Label();
            CountryLabel = new Label();
            EmployeeAddressLabel = new Label();
            EmployeePhoneNumberLabel = new Label();
            EmployeeEmailLabel = new Label();
            EmployeeBirthdateLabel = new Label();
            EmployeeNameLabel = new Label();
            EmployeePhoneNumberTextBox = new TextBox();
            EmployeeEmailTextBox = new TextBox();
            EmployeeStreetAndBuildingNumberTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            EmployeeBirthDatePickerBox = new DateTimePicker();
            EmployeeNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // SkillsDropDown
            // 
            SkillsDropDown.FormattingEnabled = true;
            SkillsDropDown.ItemHeight = 25;
            SkillsDropDown.Items.AddRange(new object[] { "Database", "Full Stack", "System Design ", "Agile", "Distributed Systems", "Backend Engineering", "Frontend Engineering", "OOP", "Redis", "MongoDb", "Elastic Search" });
            SkillsDropDown.Location = new Point(370, 389);
            SkillsDropDown.Name = "SkillsDropDown";
            SkillsDropDown.SelectionMode = SelectionMode.MultiSimple;
            SkillsDropDown.Size = new Size(261, 129);
            SkillsDropDown.TabIndex = 82;
            // 
            // ErrorsMessageLabel
            // 
            ErrorsMessageLabel.AutoSize = true;
            ErrorsMessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorsMessageLabel.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorsMessageLabel.Location = new Point(190, 610);
            ErrorsMessageLabel.Name = "ErrorsMessageLabel";
            ErrorsMessageLabel.Size = new Size(0, 38);
            ErrorsMessageLabel.TabIndex = 81;
            // 
            // SuccessMessageLabel
            // 
            SuccessMessageLabel.AutoSize = true;
            SuccessMessageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SuccessMessageLabel.ForeColor = Color.FromArgb(0, 192, 0);
            SuccessMessageLabel.Location = new Point(184, 611);
            SuccessMessageLabel.Name = "SuccessMessageLabel";
            SuccessMessageLabel.Size = new Size(0, 45);
            SuccessMessageLabel.TabIndex = 80;
            // 
            // AddNewEmployeeButton
            // 
            AddNewEmployeeButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewEmployeeButton.ForeColor = Color.FromArgb(0, 0, 192);
            AddNewEmployeeButton.Location = new Point(190, 540);
            AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            AddNewEmployeeButton.Size = new Size(339, 54);
            AddNewEmployeeButton.TabIndex = 79;
            AddNewEmployeeButton.Text = "Add New Employee";
            AddNewEmployeeButton.UseVisualStyleBackColor = true;
            AddNewEmployeeButton.Click += AddNewEmployeeButton_Click;
            // 
            // EmployeeSkillsLabel
            // 
            EmployeeSkillsLabel.AutoSize = true;
            EmployeeSkillsLabel.Location = new Point(190, 408);
            EmployeeSkillsLabel.Name = "EmployeeSkillsLabel";
            EmployeeSkillsLabel.Size = new Size(143, 25);
            EmployeeSkillsLabel.TabIndex = 78;
            EmployeeSkillsLabel.Text = "Employee Skills :";
            // 
            // StreetAndBuildingNumberLabel
            // 
            StreetAndBuildingNumberLabel.AutoSize = true;
            StreetAndBuildingNumberLabel.Location = new Point(1009, 303);
            StreetAndBuildingNumberLabel.Name = "StreetAndBuildingNumberLabel";
            StreetAndBuildingNumberLabel.Size = new Size(231, 25);
            StreetAndBuildingNumberLabel.TabIndex = 77;
            StreetAndBuildingNumberLabel.Text = "Street and Building Number";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(701, 300);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 76;
            CityLabel.Text = "City";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(398, 300);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(75, 25);
            CountryLabel.TabIndex = 75;
            CountryLabel.Text = "Country";
            // 
            // EmployeeAddressLabel
            // 
            EmployeeAddressLabel.AutoSize = true;
            EmployeeAddressLabel.Location = new Point(186, 328);
            EmployeeAddressLabel.Name = "EmployeeAddressLabel";
            EmployeeAddressLabel.Size = new Size(169, 25);
            EmployeeAddressLabel.TabIndex = 74;
            EmployeeAddressLabel.Text = "Employee Address :";
            // 
            // EmployeePhoneNumberLabel
            // 
            EmployeePhoneNumberLabel.AutoSize = true;
            EmployeePhoneNumberLabel.Location = new Point(762, 194);
            EmployeePhoneNumberLabel.Name = "EmployeePhoneNumberLabel";
            EmployeePhoneNumberLabel.Size = new Size(215, 25);
            EmployeePhoneNumberLabel.TabIndex = 73;
            EmployeePhoneNumberLabel.Text = "Employee Phone Number";
            // 
            // EmployeeEmailLabel
            // 
            EmployeeEmailLabel.AutoSize = true;
            EmployeeEmailLabel.Location = new Point(182, 194);
            EmployeeEmailLabel.Name = "EmployeeEmailLabel";
            EmployeeEmailLabel.Size = new Size(137, 25);
            EmployeeEmailLabel.TabIndex = 72;
            EmployeeEmailLabel.Text = "Employee Email";
            // 
            // EmployeeBirthdateLabel
            // 
            EmployeeBirthdateLabel.AutoSize = true;
            EmployeeBirthdateLabel.Location = new Point(762, 105);
            EmployeeBirthdateLabel.Name = "EmployeeBirthdateLabel";
            EmployeeBirthdateLabel.Size = new Size(171, 25);
            EmployeeBirthdateLabel.TabIndex = 71;
            EmployeeBirthdateLabel.Text = "Employee Birthdate ";
            // 
            // EmployeeNameLabel
            // 
            EmployeeNameLabel.AutoSize = true;
            EmployeeNameLabel.Location = new Point(186, 105);
            EmployeeNameLabel.Name = "EmployeeNameLabel";
            EmployeeNameLabel.Size = new Size(147, 25);
            EmployeeNameLabel.TabIndex = 70;
            EmployeeNameLabel.Text = "Employee Name ";
            // 
            // EmployeePhoneNumberTextBox
            // 
            EmployeePhoneNumberTextBox.Location = new Point(762, 222);
            EmployeePhoneNumberTextBox.Name = "EmployeePhoneNumberTextBox";
            EmployeePhoneNumberTextBox.Size = new Size(454, 31);
            EmployeePhoneNumberTextBox.TabIndex = 69;
            // 
            // EmployeeEmailTextBox
            // 
            EmployeeEmailTextBox.Location = new Point(182, 222);
            EmployeeEmailTextBox.Name = "EmployeeEmailTextBox";
            EmployeeEmailTextBox.Size = new Size(482, 31);
            EmployeeEmailTextBox.TabIndex = 68;
            // 
            // EmployeeStreetAndBuildingNumberTextBox
            // 
            EmployeeStreetAndBuildingNumberTextBox.Location = new Point(1009, 331);
            EmployeeStreetAndBuildingNumberTextBox.Name = "EmployeeStreetAndBuildingNumberTextBox";
            EmployeeStreetAndBuildingNumberTextBox.Size = new Size(266, 31);
            EmployeeStreetAndBuildingNumberTextBox.TabIndex = 67;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(701, 328);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(266, 31);
            CityTextBox.TabIndex = 66;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(370, 328);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(294, 31);
            CountryTextBox.TabIndex = 65;
            // 
            // EmployeeBirthDatePickerBox
            // 
            EmployeeBirthDatePickerBox.Location = new Point(762, 140);
            EmployeeBirthDatePickerBox.Name = "EmployeeBirthDatePickerBox";
            EmployeeBirthDatePickerBox.Size = new Size(454, 31);
            EmployeeBirthDatePickerBox.TabIndex = 64;
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(182, 140);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.Size = new Size(482, 31);
            EmployeeNameTextBox.TabIndex = 63;
            // 
            // AddNewEmployeeByManagerForm_3_MongoDatabaseExample
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 760);
            Controls.Add(SkillsDropDown);
            Controls.Add(ErrorsMessageLabel);
            Controls.Add(SuccessMessageLabel);
            Controls.Add(AddNewEmployeeButton);
            Controls.Add(EmployeeSkillsLabel);
            Controls.Add(StreetAndBuildingNumberLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(EmployeeAddressLabel);
            Controls.Add(EmployeePhoneNumberLabel);
            Controls.Add(EmployeeEmailLabel);
            Controls.Add(EmployeeBirthdateLabel);
            Controls.Add(EmployeeNameLabel);
            Controls.Add(EmployeePhoneNumberTextBox);
            Controls.Add(EmployeeEmailTextBox);
            Controls.Add(EmployeeStreetAndBuildingNumberTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(EmployeeBirthDatePickerBox);
            Controls.Add(EmployeeNameTextBox);
            Name = "AddNewEmployeeByManagerForm_3_MongoDatabaseExample";
            Text = "AddNewEmployeeByManagerForm_3_MongoDatabaseExample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SkillsDropDown;
        private Label ErrorsMessageLabel;
        private Label SuccessMessageLabel;
        private Button AddNewEmployeeButton;
        private Label EmployeeSkillsLabel;
        private Label StreetAndBuildingNumberLabel;
        private Label CityLabel;
        private Label CountryLabel;
        private Label EmployeeAddressLabel;
        private Label EmployeePhoneNumberLabel;
        private Label EmployeeEmailLabel;
        private Label EmployeeBirthdateLabel;
        private Label EmployeeNameLabel;
        private TextBox EmployeePhoneNumberTextBox;
        private TextBox EmployeeEmailTextBox;
        private TextBox EmployeeStreetAndBuildingNumberTextBox;
        private TextBox CityTextBox;
        private TextBox CountryTextBox;
        private DateTimePicker EmployeeBirthDatePickerBox;
        private TextBox EmployeeNameTextBox;
    }
}