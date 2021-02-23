using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseASP.Services;
using DatabaseASP.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseASP.Pages
{
    public class AddMovieModel : PageModel
    {
        public IMovieService _ms;
        [BindProperty]
        public MovieViewModel MVM { get; set; }
        public void OnGet()
        {

        }
        public AddMovieModel(IMovieService ms)
        {
            _ms = ms;
            MVM = new MovieViewModel();
        }
        public IActionResult OnPost()
        {
            _ms.AddMovie(new Models.Movies { Name = MVM.Name, gender = MVM.gender, release = MVM.release });
            return RedirectToPage("./Index");
        }
    }
}