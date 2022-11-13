using Domain.Objects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Product
{
    public class Product : AggregationRootAudit<long>
    {
        public string Name { set; get; }
    }
}
