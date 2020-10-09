using IncunabulaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Data
{
    public interface IRepository
    {
        IEnumerable<Book> Books { get; }
    }
}
