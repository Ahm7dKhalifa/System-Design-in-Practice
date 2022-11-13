using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Shared
{
    public class AggregationRootAudit<Key> : AggregationRoot<Key>
    {
        public DateTime? CreatedAt  { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public long? LastUpdatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
        public long? DeletedBy { get; set; }
    }
}
