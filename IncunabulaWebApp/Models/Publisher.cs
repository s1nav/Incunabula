using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public List<Book> Books { get; set; }
    }
}
