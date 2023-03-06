using Domain.Core.Shared;
using Domain.InfrastructureInterfaces.Databases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.Databases.PrimaryDatabase.Repositories
{
    public interface IGenericRepository<Type,Id> where Type : AggregationRoot<Id>
    {
        Task<Type> GetByIdAsync(Id id);
        Type GetById(Id id);
        Task<List<Type>> GetAllAsync(ListParameters<Type> listParameters);
        List<Type> GetAll(ListParameters<Type> listParameters);
    }
}
