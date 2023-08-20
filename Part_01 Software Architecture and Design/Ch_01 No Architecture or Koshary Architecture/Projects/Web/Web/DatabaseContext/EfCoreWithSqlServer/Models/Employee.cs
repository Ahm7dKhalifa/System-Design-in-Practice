using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koshary_Architecture_Web.DatabaseContext.EfCoreWithSqlServer.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? StreetAndBuildingNumber { get; set; }
        public string Email { get; set; } = "";
        public string? PhoneNumber { get; set; }
        public List<EmployeeSkill>? EmployeeSkills { get; set;}

    }
}
