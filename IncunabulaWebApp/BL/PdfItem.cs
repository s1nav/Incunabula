using IncunabulaWebApp.Enums;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncunabulaWebApp.BL
{
    public class PdfItem : BookItem
    {
        public override FileFormat FileFormat { get; set; }
        public override string Author { get; set; }
        public override string Title { get; set; }
        public override int? NumberOfPages { get; set; }

        public PdfItem (string path)
            : base (path)
        {
            this.FileFormat = FileFormat.Pdf;

            var pdfDoc = new PdfDocument(new PdfReader(path));
            Author = pdfDoc.GetDocumentInfo().GetAuthor();
            Title = pdfDoc.GetDocumentInfo().GetTitle();
            NumberOfPages = pdfDoc.GetNumberOfPages();
        }


    }
}
