using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Shared
{
    public class AggregationRoot<Key>
    {
        public Key Id { get; set; }
    }
}
