using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koshary_Architecture.DatabaseContext.DriverWithMongoDatabase.Models
{
    public static class MongoDBSettings
    {

        public static string ConnectionURI = "mongodb://localhost:27017";
        public static string DatabaseName = "EmployeesDatabase";
        public static string CollectionName { get; set; } = "EmployeesCollection";

    }
}
