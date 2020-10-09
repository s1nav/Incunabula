using IncunabulaWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncunabulaWebApp.ModelsConfiguration
{
    public class FileItemConfiguration : IEntityTypeConfiguration<FileItem>
    {
        public void Configure(EntityTypeBuilder<FileItem> builder)
        {
            builder.HasAlternateKey(f => f.MD5Hash);
        }
    }
}
