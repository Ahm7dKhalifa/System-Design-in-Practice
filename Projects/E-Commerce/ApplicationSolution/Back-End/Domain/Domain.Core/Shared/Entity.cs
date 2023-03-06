using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Shared
{
    public class Entity<T>
    {
        public T Id { get; set; }
    }
}
