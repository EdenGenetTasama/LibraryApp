using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public Book(string _name , string _writter, int _pages)
        {
            this.Name = _name;
            this.NumbersOfPages = _pages;
            this.Writter = _writter; 
        }

        public string Name { get; set; }
        public string Writter { get; set; }
        public int NumbersOfPages { get; set; }

    }
}
