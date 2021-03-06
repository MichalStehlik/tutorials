using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWEBAsp.Services
{
    public interface IMovieStorage<T>
    {
        //zde vytvoříme všechny funkce nebo listy, která budeme chtít volat na stránkách
        List<T> Content { get; }
    }
}
