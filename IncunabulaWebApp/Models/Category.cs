using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
