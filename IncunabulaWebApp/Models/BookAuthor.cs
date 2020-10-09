using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class BookAuthor
    {
        public int BookID { get; set; }
        public Book Book { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
