using FirstWEBAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWEBAsp.Services
{
    public class MovieStorage: IMovieStorage<Movie>
    {
        //list našich filmů 
        public List<Movie> Content { get; set; }
        //konstruktor ve kterém vytváříme nový objekt podle modelu movie
        public MovieStorage()
        {
            Content = new List<Movie>();
            Content.Add(new Movie { Name = "Star Wars:Nová naděje", 
                                    gender = "sci-fi", 
                                    release = new DateTime(1977,5, 25) });
        }
    }
}
