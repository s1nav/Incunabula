using IncunabulaWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.Data
{
    public class DataRepository : IRepository
    {
        private DataContext dataContext;
        public DataRepository(DataContext ctx) => dataContext = ctx;
        
        public IEnumerable<Book> Books => dataContext.Books.Include(b=>b.Publisher).Include(b=>b.BookAuthors).ThenInclude(ba=>ba.Author);

        public void AddBook(Book book)
        {
            this.dataContext.Books.Add(book);
            this.dataContext.SaveChanges();
        }
    }
}
