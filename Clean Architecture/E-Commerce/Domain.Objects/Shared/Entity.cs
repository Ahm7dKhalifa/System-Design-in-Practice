using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Shared
{
    public class Entity<Key>
    {
        public Key Id { get; set; }
    }
}
