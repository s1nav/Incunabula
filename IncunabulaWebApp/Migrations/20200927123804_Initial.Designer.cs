﻿// <auto-generated />
using System;
using IncunabulaWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IncunabulaWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200927123804_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("IncunabulaWebApp.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookAuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasPhoto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SortName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TranslatedName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookAuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Edition")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasCover")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PublishDate")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("Description");

                    b.HasIndex("LanguageID");

                    b.HasIndex("PublisherID");

                    b.HasIndex("Title");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasAlternateKey("Name");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.FileItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Format")
                        .HasColumnType("TEXT");

                    b.Property<string>("MD5Hash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasAlternateKey("MD5Hash");

                    b.HasIndex("BookID");

                    b.ToTable("FileItems");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Identifier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificator")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.ToTable("Identifiers");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasAlternateKey("Name");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasAlternateKey("Name");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Book", b =>
                {
                    b.HasOne("IncunabulaWebApp.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID");

                    b.HasOne("IncunabulaWebApp.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageID");

                    b.HasOne("IncunabulaWebApp.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.BookAuthor", b =>
                {
                    b.HasOne("IncunabulaWebApp.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncunabulaWebApp.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.FileItem", b =>
                {
                    b.HasOne("IncunabulaWebApp.Models.Book", "Book")
                        .WithMany("FileItems")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IncunabulaWebApp.Models.Identifier", b =>
                {
                    b.HasOne("IncunabulaWebApp.Models.Book", "Book")
                        .WithMany("Identifiers")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}