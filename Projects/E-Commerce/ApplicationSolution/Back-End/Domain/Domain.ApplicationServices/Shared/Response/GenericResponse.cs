using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationServices.Shared.Response
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public ResponseStatusEnum ResponseStatus { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
