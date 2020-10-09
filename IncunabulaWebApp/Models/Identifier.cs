using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class Identifier
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Identificator { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
