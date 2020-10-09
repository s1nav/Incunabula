using IncunabulaWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.ModelsConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasIndex(b => b.Title);
            builder.HasIndex(b => b.Description);
            //builder.Property(b => b.AddDate).HasDefaultValue(DateTime.Now.ToFileTime());
        }
    }
}
