using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.EmailsServices.Models
{
    public class EmailToSendOutputModel
    {
        public bool Success { get; set; }
        public string Exception { get; set; }
    }
}
