using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Shared
{
    public class AggregationRootFullAudit<IdType> : AggregationRoot<IdType>
    {
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedLastTimeAt { get; set; }
        public long? UpdatedLastTimeBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long? DeleteBy { get; set; }

    }
}
