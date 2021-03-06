using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWEBAsp.Models;
using FirstWEBAsp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FirstWEBAsp.Pages
{
    public class IndexModel : PageModel
    {
        //Voláme interface, který zde pojmenujeme je MovieStorage
        public IMovieStorage<Movie> MovieStorage { get; set; }
        public List<Movie> List { get; set; }

        public IndexModel(IMovieStorage<Movie> movieStorage)
        {
            this.MovieStorage = movieStorage;
            this.List = new List<Movie>();
        }
        //Zde v OnGet projedeme náš List s filmy pomocí foreach a vypíšeme náš item
        public void OnGet()
        {
            foreach (var item in MovieStorage.Content)
            {
                List.Add(item);
            }
        }
    }
}
