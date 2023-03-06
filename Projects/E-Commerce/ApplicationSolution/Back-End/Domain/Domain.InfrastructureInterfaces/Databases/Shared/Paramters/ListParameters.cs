using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.Databases.Shared
{
    public class ListParameters<Type>
    {
        public PagingParameters PagingParameters;
        public List<Expression<Func<Type, bool>>> WhereConditions = new List<Expression<Func<Type, bool>>>();

        public ListParameters<Type> Create()
        {
            return new ListParameters<Type>(); 
        }

    }
}
