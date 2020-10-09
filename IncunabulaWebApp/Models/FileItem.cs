using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Models
{
    public class FileItem
    {
        public int ID { get; set; }
        public int Size { get; set; }
        public string FileName { get; set; }
        public int? PageCount { get; set; }
        public string MD5Hash { get; set; }
        public string Format { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
