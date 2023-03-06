using Domain.Core.Products;
using Domain.InfrastructureInterfaces.Databases.PrimaryDatabase.Repositories;
using Domain.InfrastructureInterfaces.Databases.Shared;
using Infrastructure.Database.SqlServer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IDatabase _redisDatabase;
        private readonly DatabaseContext _sqlDatabase;
        private readonly IProductsPrimaryDatabaseRepository _productsPrimaryDatabaseRepository;
        public ProductsController(ILogger<WeatherForecastController> logger
                                       , IDatabase redisDatabase
                                       , DatabaseContext sqlDatabase
                                       , IProductsPrimaryDatabaseRepository productsPrimaryDatabaseRepository)
        {
            _redisDatabase = redisDatabase;
            _sqlDatabase = sqlDatabase;
            _productsPrimaryDatabaseRepository = productsPrimaryDatabaseRepository;


        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            _redisDatabase.StringSet("test-key", "hello from application");

            List<Product> products = await _sqlDatabase.Products.ToListAsync();

            var ListParameters = new ListParameters<Product>();

            ListParameters.PagingParameters = new PagingParameters(1, 5);

            ListParameters.WhereConditions.Add(p => p.Deleted == false);

            ListParameters.WhereConditions.Add(p => p.TotalCountOfViewers > 6);

            return await _productsPrimaryDatabaseRepository.GetProductsOrderedDescByTotalNumbersOfLikes(ListParameters);


        }
    }
}
