using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseASP.Models;
using DatabaseASP.Services;
using DatabaseASP.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DatabaseASP.Pages
{
    public class IndexModel : PageModel
    {
        public IMovieService _movieService;
        public MovieViewModel Movie { get; set; }
        [BindProperty]
        public List<Movies> Movies { get; set; }
        public IndexModel(IMovieService movieService)
        {
            _movieService = movieService;
            Movies = new List<Movies>();
        }
        public void OnGet()
        {
            Movies = _movieService.GetMovies();
        }
        public void OnGetRemove(int id)
        {
            _movieService.RemoveMovie(id);
            OnGet();
        }
            
    }
}
