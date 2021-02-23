using DatabaseASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseASP.Services
{
    public interface IMovieService
    {
        List<Movies> Movies { get;  }
        List<Movies> GetMovies();
        void AddMovie(Movies movies);
        void RemoveMovie(int id);
    }
}
