using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Books
    {
        public List<Book> booklist;
        public Books()
        {
            booklist = new List<Book>()
            {
                new Book{ Name="War and Peace", Author="L.Tolstoy", Price = 40, Id=1},
                new Book{ Name="Fathers and Sons", Author="I.Turgenyev", Price = 60, Id=2},
                new Book{ Name="Chaika", Author="A.Chehov", Price = 80, Id=3},
                new Book{ Name="Gan Edem", Author="Hai Ben Adam", Price = 100, Id=4},
                new Book{ Name= "MVC Tutorial", Author="Stephan King", Price = 120, Id=5},
            };
        }
    }
    
}
