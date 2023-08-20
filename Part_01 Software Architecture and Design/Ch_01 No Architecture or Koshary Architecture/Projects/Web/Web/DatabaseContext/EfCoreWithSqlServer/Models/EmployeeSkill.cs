using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koshary_Architecture_Web.DatabaseContext.EfCoreWithSqlServer.Models
{
    public class EmployeeSkill
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string? SkillName { get; set; }
    }
}
