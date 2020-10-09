using IncunabulaWebApp.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace IncunabulaWebApp.BL
{
    public abstract class BookItem
    {
        public virtual string Path { get; set; }
        public virtual string Hash { get; set; }
        public virtual FileInfo FileInfo { get; set; }
        public virtual long FileSize { get; set; }
        public virtual FileFormat FileFormat { get; set; }
        public abstract string Author { get; set; }
        public abstract string Title { get; set; }
        public abstract int? NumberOfPages { get; set; }

        public BookItem (string path)
        {
            Path = path;
            Hash = GetHash();
            FileInfo = new FileInfo(path);
            FileSize = FileInfo.Length;
        }

        public static BookItem Create(string path)
        {

            var fileExtension = new FileInfo(path).Extension.Replace(".", "");
            Enum.TryParse(fileExtension, out FileFormat fileFormat);

            return fileFormat switch
            {
                FileFormat.Epub => new EpubItem(path),
                FileFormat.Pdf => new PdfItem(path),
                _ => new DefaultItem(path),
            };
        }

        public virtual string GetHash()
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(Path))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

    }
}
