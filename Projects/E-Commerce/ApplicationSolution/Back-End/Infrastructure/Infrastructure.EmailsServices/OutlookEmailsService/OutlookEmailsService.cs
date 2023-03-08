using Domain.InfrastructureInterfaces.EmailServices;
using Domain.InfrastructureInterfaces.EmailsServices.Models;
using System;

namespace Infrastructure.EmailsServices.Microsoft
{
    public class OutlookEmailsService : EmailsService
    {
        public EmailToSendOutputModel Send(EmailToSendInputModel inputModel)
        {
            EmailToSendOutputModel result = new EmailToSendOutputModel();

            try
            {
                //write send email code here ....
                result.Success = true;
            }
            catch(Exception ex)
            {
                result.Exception = ex.ToString();
                result.Success = false;
            }

            return result;
        }
    }
}
