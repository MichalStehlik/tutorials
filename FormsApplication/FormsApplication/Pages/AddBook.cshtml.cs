using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsApplication.Models;
using FormsApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FormsApplication.Pages
{
    public class AddBookModel : PageModel
    {
        public IBookService<Book> BookService { get; set; }
        public string Autor { get; set; }
        public string Name { get; set;  }
        public bool IsRead { get; set; }
        public AddBookModel(IBookService<Book> bookService)
        {
            BookService = bookService;
        }
        public IActionResult OnPost(string autor, string name, bool isread)
        {
            Autor = autor;
            Name = name;
            IsRead = isread;
            BookService.Content.Add(new Book { Autor = autor, Name = name, IsRead = isread });
            return RedirectToPage("./Index");
        }
        
    }
}
