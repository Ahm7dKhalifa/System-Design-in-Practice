using Koshary_Architecture_Web.DatabaseContext.EfCoreWithSqlServer.Models;

namespace Koshary_Architecture_Web.UI_Models
{
    public class NewEmployeeUserInterfaceModel
    {
        public string? Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? StreetAndBuildingNumber { get; set; }
        public string Email { get; set; } = "";
        public string? PhoneNumber { get; set; }
        public string? EmployeeSkill_1 { get; set; }
        public string? EmployeeSkill_2 { get; set; }
        public string? EmployeeSkill_3 { get; set; }
        public string? EmployeeSkill_4 { get; set; }
        public string? EmployeeSkill_5 { get; set; }
        public string? EmployeeSkill_6 { get; set; }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
}
