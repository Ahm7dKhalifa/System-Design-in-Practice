using Domain.InfrastructureInterfaces.EmailsServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.EmailServices
{
    public interface EmailsService
    {
        EmailToSendOutputModel Send(EmailToSendInputModel inputModel);
    }
}
