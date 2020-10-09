using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long? PublishDate { get; set; }
        public bool HasCover { get; set; }
        public string Edition { get; set; }
        public string Path { get; set; }
        public long AddDate { get; set; } = DateTime.Now.ToFileTime();

        public int? LanguageID { get; set; }
        public Language Language { get; set; }

        public int BookAuthorID { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }

        public List<FileItem> FileItems { get; set; }

        public int? CategoryID { get; set; }
        public Category Category { get; set; }

        public int? PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        public List<Identifier> Identifiers { get; set; }
    }
}
