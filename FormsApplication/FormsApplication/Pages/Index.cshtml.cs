using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsApplication.Models;
using FormsApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FormsApplication.Pages
{
    public class IndexModel : PageModel
    {
        public List<Book> Books { get; set; }
        public IBookService<Book> BookService { get; set; }
        public IndexModel(IBookService<Book> bookService)
        {
            BookService = bookService;
            Books = new List<Book>();
        }
        public void OnGet()
        {
            foreach (var item in BookService.Content)
            {
                Books.Add(item);
            }
        }
    }
}
