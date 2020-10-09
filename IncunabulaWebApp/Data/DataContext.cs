using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IncunabulaWebApp.Models;
using IncunabulaWebApp.ModelsConfiguration;

namespace IncunabulaWebApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FileItem> FileItems { get; set; }
        public DbSet<Identifier> Identifiers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=incunabula.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            //modelBuilder.ApplyConfiguration(new BookConfiguration());
            //modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            //modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
        }
    }
}
