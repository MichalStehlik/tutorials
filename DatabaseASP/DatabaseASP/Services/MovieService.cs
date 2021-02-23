using DatabaseASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseASP.Services
{
    public class MovieService : IMovieService
    {
        public ApplicationDbContext _db { get; set; }
        public MovieService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Movies> Movies { get => _db.Movies.ToList(); }
        public List<Movies> GetMovies()
        {
            return _db.Movies.ToList();
        }
        public void AddMovie(Movies movies)
        {
            _db.Movies.Add(movies);
            _db.SaveChanges();
        }
        public void RemoveMovie(int id)
        {
            _db.Movies.Remove(Movies.Find(x => x.Id == id));
            _db.SaveChanges();
        }
    }
}
