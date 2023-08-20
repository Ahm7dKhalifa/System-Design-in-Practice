using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Koshary_Architecture.UI_Forms;
using Koshary_Architecture.DatabaseContext.EfCoreWithSqlServer;
using Koshary_Architecture.DatabaseContext.EfCoreWithSqlServer.Models;

namespace Koshary_Architecture
{
    public partial class Example_1 : Form
    {
        #region Properties
        List<string> Errors = new List<string>();
        EmployeesSqlServerDatabaseContext SqlServerDatabaseContext = new EmployeesSqlServerDatabaseContext();
        Employee NewEmployee = new Employee();
        #endregion
        public Example_1()
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

            bool isPhoneNumberExist = SqlServerDatabaseContext
                                       .Employees
                                       .Where(e => e.PhoneNumber == EmployeePhoneNumberTextBox.Text)
                                       .Any();
            if (isPhoneNumberExist)
            {
                Errors.Add("Phone number is already exist , please enter unique phone number. ");
            }
        }


        private void CheckIfEmployeeHasAtLeastOneSkill()
        {
            if (string.IsNullOrWhiteSpace(EmployeeSkillTextBox_1.Text))
            {
                Errors.Add("Employee should has at least one skill , " +
                           "please ensure the skill is entered on the first cell. ");
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
            employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_1.Text });
            if (!string.IsNullOrEmpty(EmployeeSkillTextBox_2.Text))
                employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_2.Text });
            if (!string.IsNullOrEmpty(EmployeeSkillTextBox_3.Text))
                employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_3.Text });
            if (!string.IsNullOrEmpty(EmployeeSkillTextBox_4.Text))
                employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_4.Text });
            if (!string.IsNullOrEmpty(EmployeeSkillTextBox_5.Text))
                employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_5.Text });
            if (!string.IsNullOrEmpty(EmployeeSkillTextBox_6.Text))
                employeeSkills.Add(new EmployeeSkill { SkillName = EmployeeSkillTextBox_6.Text });

            NewEmployee.EmployeeSkills = employeeSkills;
        }

        private void SaveNewEmployeeOnDatabase()
        {
            SqlServerDatabaseContext.Employees.Add(NewEmployee);
            SqlServerDatabaseContext.SaveChanges();
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

        private void GoToNextExampleButton_Click(object sender, EventArgs e)
        {
            Example_2 next = new Example_2();
            next.Show();
        }
    }
}

