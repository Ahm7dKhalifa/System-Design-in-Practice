using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.Databases.Shared
{
    public class PagingParameters
    {
        public int PageNumber = 1;
        public int PageSize = 10;

        public PagingParameters(int pageNumber , int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
