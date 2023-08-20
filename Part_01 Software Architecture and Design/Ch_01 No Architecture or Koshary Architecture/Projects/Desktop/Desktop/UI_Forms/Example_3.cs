using Koshary_Architecture.DatabaseContext.DriverWithMongoDatabase;
using Koshary_Architecture.DatabaseContext.DriverWithMongoDatabase.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Koshary_Architecture.UI_Forms
{
    public partial class Example_3 : Form
    {
        #region Properties
        List<string> Errors = new List<string>();
        Employee NewEmployee = new Employee();
        #endregion

        public Example_3()
        {
            InitializeComponent();
        }
        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            InitUiConfiguration();

            CheckIfEmployeeAgeIsEqualOrGreaterThan21Years();
            CheckIfEmailHasCorrectFormat();
            CheckIfEmployeePhoneNumberIsRequiredAndUnique();
            CheckIfEmployeeHasAtLeastOneSkill();

            if (Errors.Count > 0)
            {
                DisplayErrorMessage();
            }
            else
            {
                CreateNewEmployee();
                SaveNewEmployeeOnDatabase();
                SendEmailNotificationToAdmin();
                DisplaySuccessMessage();
            }
        }

        private void InitUiConfiguration()
        {
            Errors = new List<string>();

            NewEmployee = new Employee();

            SuccessMessageLabel.Text = string.Empty;
            SuccessMessageLabel.Visible = false;
            ErrorsMessageLabel.Text = string.Empty;
            ErrorsMessageLabel.Visible = false;
        }

        private void CheckIfEmployeeAgeIsEqualOrGreaterThan21Years()
        {
            DateTime today = DateTime.Now;
            var age = today.Year - EmployeeBirthDatePickerBox.Value.Year;
            if (age < 21)
            {
                Errors.Add("Employee age should be equal or greater than 21 years.");
            }
        }

        private void CheckIfEmailHasCorrectFormat()
        {
            if (string.IsNullOrEmpty(EmployeeEmailTextBox.Text))
                return;

            bool isEmail = Regex.IsMatch(EmployeeEmailTextBox.Text,
                                         @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                                         RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                Errors.Add("Employee email must has correct format.");
            }

        }


        private void CheckIfEmployeePhoneNumberIsRequiredAndUnique()
        {
            if (string.IsNullOrEmpty(EmployeePhoneNumberTextBox.Text))
            {
                Errors.Add("Phone number is required. ");
            }

            MongoClient mongoClient = new MongoClient(MongoDBSettings.ConnectionURI);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(MongoDBSettings.DatabaseName);
            var employeesCollection = mongoDatabase.GetCollection<Employee>(MongoDBSettings.CollectionName);

            bool isPhoneNumberExist = employeesCollection
                                     .CountDocuments(employee => employee.PhoneNumber == EmployeePhoneNumberTextBox.Text)
                                     > 0;

            if (isPhoneNumberExist)
            {
                Errors.Add("Phone number is already exist , please enter unique phone number. ");
            }
        }


        private void CheckIfEmployeeHasAtLeastOneSkill()
        {
            if (SkillsDropDown.SelectedItems.Count <= 0)
            {
                Errors.Add("Employee should has at least one skill. ");

            }
        }

        private void CreateNewEmployee()
        {
            NewEmployee = new Employee();
            NewEmployee.Name = EmployeeNameTextBox.Text;
            NewEmployee.Birthdate = EmployeeBirthDatePickerBox.Value;
            NewEmployee.Email = EmployeeEmailTextBox.Text;
            NewEmployee.PhoneNumber = EmployeePhoneNumberTextBox.Text;
            NewEmployee.Country = CountryTextBox.Text;
            NewEmployee.City = CityTextBox.Text;
            NewEmployee.StreetAndBuildingNumber = EmployeeStreetAndBuildingNumberTextBox.Text;

            List<EmployeeSkill> employeeSkills = new List<EmployeeSkill>();
            foreach (var selectedSkill in SkillsDropDown.SelectedItems)
            {
                employeeSkills.Add(new EmployeeSkill { SkillName = selectedSkill.ToString() });
            }
            NewEmployee.EmployeeSkills = employeeSkills;
        }

        private void SaveNewEmployeeOnDatabase()
        {
            MongoClient mongoClient = new MongoClient(MongoDBSettings.ConnectionURI);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(MongoDBSettings.DatabaseName);
            var employeesCollection = mongoDatabase.GetCollection<Employee>(MongoDBSettings.CollectionName);

            employeesCollection.InsertOne(NewEmployee);
        }

        private void SendEmailNotificationToAdmin()
        {
            Console.WriteLine("Email is sent ...");
            Console.WriteLine("you can uncomment the code below to send actual email ");
            /*
            https://www.c-sharpcorner.com/article/sending-email-using-c-sharp/
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("FromMailAddress");
            message.To.Add(new MailAddress("ToMailAddress"));
            message.Subject = "Test";
            message.IsBodyHtml = true; //to make message body as html
            message.Body = htmlString;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("FromMailAddress", "password");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            */
        }


        private void DisplaySuccessMessage()
        {
            SuccessMessageLabel.Text = "Employee " + NewEmployee.Name + " is added successfuly :)";
            SuccessMessageLabel.Visible = true;
        }

        private void DisplayErrorMessage()
        {
            string errorMessage = string.Empty;
            foreach (var error in Errors)
            {
                errorMessage += error + "\r\n";
            }
            ErrorsMessageLabel.Text = errorMessage;
            ErrorsMessageLabel.Visible = true;
        }
    }
}
