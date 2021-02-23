using FormsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApplication.Services
{
    public class BookService : IBookService<Book>
    {
        public List<Book> Content { get; set; }
        public BookService()
        {
            Content = new List<Book>();
            Content.Add(new Book { Name = "Deset malých černoušku",
                                   Autor = "A. Christie",
                                   IsRead = true});
        }
    }
}
