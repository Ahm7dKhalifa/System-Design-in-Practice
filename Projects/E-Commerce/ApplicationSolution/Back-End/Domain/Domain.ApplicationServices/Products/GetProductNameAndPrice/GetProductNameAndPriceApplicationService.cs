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
    public class GetProductNameAndPriceApplicationService : IGetProductNameAndPriceApplicationService
    {
        private readonly IProductsPrimaryDatabaseRepository ProductsPrimaryDatabaseRepository;
        public GetProductNameAndPriceApplicationService(
                       IProductsPrimaryDatabaseRepository productsPrimaryDatabaseRepository)
        {
            ProductsPrimaryDatabaseRepository = productsPrimaryDatabaseRepository;
        }

        public async Task<GenericResponse<GetProductNameAndPriceOutputModel>> Execute(long productId)
        {
            Product product = await ProductsPrimaryDatabaseRepository.GetProductById(productId);

            if (product == null)
                return GenericResponseFactory.BuildNotFoundResponse<GetProductNameAndPriceOutputModel>();

            GetProductNameAndPriceOutputModel productDto = new GetProductNameAndPriceOutputModel();
            productDto.ProductName = product.Name;
            productDto.ProductPrice = product.Price.PriceValue;

            return GenericResponseFactory.BuildSuccessResponse<GetProductNameAndPriceOutputModel>(productDto);

        }
    }
}

