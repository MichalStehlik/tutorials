using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApplication.Services
{
    public interface IBookService<T>
    {
        List<T> Content { get; }
    }
}
