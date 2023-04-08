using Domain.InfrastructureInterfaces.EmailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationServices.Products
{
    public class CreateProductBySalesEmployeeApplicationService
    {
        private readonly EmailsService EmailsService;

        public CreateProductBySalesEmployeeApplicationService(EmailsService emailsService)
        {
            EmailsService = emailsService;
        }


    }
}
