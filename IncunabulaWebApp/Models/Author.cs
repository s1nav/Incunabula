using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TranslatedName { get; set; }
        public string Description { get; set; }
        public bool HasPhoto { get; set; }
        public string SortName { get; set; }

        public int BookAuthorID { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
