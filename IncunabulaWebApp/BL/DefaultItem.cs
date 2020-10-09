using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncunabulaWebApp.BL
{
    public class DefaultItem : BookItem
    {
        public override string Author { get; set; }
        public override string Title { get; set; }
        public override int? NumberOfPages { get; set; }
        public DefaultItem(string path)
            : base(path)
        {

        }
    }
}
