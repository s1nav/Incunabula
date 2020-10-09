using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncunabulaWebApp.Models
{
    public class GeneralizedBook
    {
        public int BookID { get; set; }
        public string[] Authors { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
