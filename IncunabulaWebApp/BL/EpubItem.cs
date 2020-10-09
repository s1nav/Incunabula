using IncunabulaWebApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersOne.Epub;

namespace IncunabulaWebApp.BL
{
    public class EpubItem : BookItem
    {
        public override string Author { get; set; }
        public override string Title { get; set; }
        public override int? NumberOfPages { get; set; }


        public EpubItem(string path)
            : base(path)
        {
            this.FileFormat = FileFormat.Epub;

            var epubDoc = EpubReader.ReadBook(path);
            Author = epubDoc.Author;
            Title = epubDoc.Title;
        }


    }
}
