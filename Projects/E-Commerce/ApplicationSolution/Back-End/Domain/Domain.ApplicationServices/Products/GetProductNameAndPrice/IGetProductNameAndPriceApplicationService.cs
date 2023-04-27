using Domain.ApplicationServices.Products.GetProductNameAndPrice.Dtos;
using Domain.ApplicationServices.Shared.Response;
using Domain.Core.Products;
using Domain.InfrastructureInterfaces.Databases.PrimaryDatabase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationServices.Products.GetProductNameAndPrice
{
    public interface IGetProductNameAndPriceApplicationService
    {
       Task<GenericResponse<GetProductNameAndPriceOutputModel>> Execute(long productId); 
    }
}
