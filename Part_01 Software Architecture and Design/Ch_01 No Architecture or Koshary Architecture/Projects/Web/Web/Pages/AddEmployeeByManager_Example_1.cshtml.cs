using Koshary_Architecture_Web.DatabaseContext.EfCoreWithSqlServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using Koshary_Architecture_Web.DatabaseContext.EfCoreWithSqlServer;
using Koshary_Architecture_Web.UI_Models;

namespace Koshary_Architecture_Web.Pages
{
    public class AddEmployeeByManager_Example_1_Model : PageModel
    {
        #region Properties
        List<string> Errors = new List<string>();
        EmployeesSqlServerDatabaseContext SqlServerDatabaseContext = new EmployeesSqlServerDatabaseContext();
        Employee NewEmployee = new Employee();
        [BindProperty]
        public NewEmployeeUserInterfaceModel NewEmployeeUserInterfaceModel { get; set; }
        #endregion

        public void OnGet()
        {
            NewEmployeeUserInterfaceModel = new NewEmployeeUserInterfaceModel();
        }

        public void OnPost()
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

            if (NewEmployeeUserInterfaceModel == null)
                NewEmployeeUserInterfaceModel = new NewEmployeeUserInterfaceModel();
        }

        private void CheckIfEmployeeAgeIsEqualOrGreaterThan21Years()
        {
            DateTime today = DateTime.Now;
            var age = today.Year - NewEmployeeUserInterfaceModel.Birthdate.Year;
            if (age < 21)
            {
                Errors.Add("Employee age should be equal or greater than 21 years.");
            }
        }

        private void CheckIfEmailHasCorrectFormat()
        {
            if (string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.Email))
                return;

            bool isEmail = Regex.IsMatch(NewEmployeeUserInterfaceModel.Email,
                                         @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                                         RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                Errors.Add("Employee email must has correct format.");
            }
        }

        private void CheckIfEmployeePhoneNumberIsRequiredAndUnique()
        {
            if (string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.PhoneNumber))
            {
                Errors.Add("Phone number is required. ");
            }

            bool isPhoneNumberExist =   SqlServerDatabaseContext
                                       .Employees
                                       .Where(e => e.PhoneNumber == NewEmployeeUserInterfaceModel.PhoneNumber)
                                       .Any();
            if (isPhoneNumberExist)
            {
                Errors.Add("Phone number is already exist , please enter unique phone number. ");
            }
        }


        private void CheckIfEmployeeHasAtLeastOneSkill()
        {
            if (string.IsNullOrWhiteSpace(NewEmployeeUserInterfaceModel.EmployeeSkill_1))
            {
                Errors.Add("Employee should has at least one skill , " +
                           "please ensure the skill is entered on the first cell. ");
            }
        }

        private void CreateNewEmployee()
        {
            NewEmployee = new Employee();
            NewEmployee.Name = NewEmployeeUserInterfaceModel.Name;
            NewEmployee.Birthdate = NewEmployeeUserInterfaceModel.Birthdate;
            NewEmployee.Email = NewEmployeeUserInterfaceModel.Email;
            NewEmployee.PhoneNumber = NewEmployeeUserInterfaceModel.PhoneNumber;
            NewEmployee.Country = NewEmployeeUserInterfaceModel.Country;
            NewEmployee.City = NewEmployeeUserInterfaceModel.City;
            NewEmployee.StreetAndBuildingNumber = NewEmployeeUserInterfaceModel.StreetAndBuildingNumber;

            List<EmployeeSkill> employeeSkills = new List<EmployeeSkill>();
            employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_1 });
            if (!string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.EmployeeSkill_2))
                employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_2 });
            if (!string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.EmployeeSkill_3))
                employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_3 });
            if (!string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.EmployeeSkill_4))
                employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_4 });
            if (!string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.EmployeeSkill_5))
                employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_5 });
            if (!string.IsNullOrEmpty(NewEmployeeUserInterfaceModel.EmployeeSkill_6))
                employeeSkills.Add(new EmployeeSkill { SkillName = NewEmployeeUserInterfaceModel.EmployeeSkill_6 });

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
            NewEmployeeUserInterfaceModel.IsSuccess = true;

            string successMessage = "Employee " + NewEmployee.Name + " is added successfuly :)";
            NewEmployeeUserInterfaceModel.Message = successMessage;
        }

        private void DisplayErrorMessage()
        {
            NewEmployeeUserInterfaceModel.IsSuccess = false;

            string errorMessage = string.Empty;
            foreach (var error in Errors)
            {
                errorMessage += error + "<br/>";
            }
            NewEmployeeUserInterfaceModel.Message = errorMessage;
        }
    }
}