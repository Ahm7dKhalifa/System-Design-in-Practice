using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Clients
{
    public class Client : AggregationRootFullAudit<long>
    {
        public string Name { get; private set; }
        public long TotalNumberOfAllOrders { get; private set; }
        public decimal TotalMoneyOfAllOrders { get; private set; }
        public bool IsActive { get; private set; }
    }
}
