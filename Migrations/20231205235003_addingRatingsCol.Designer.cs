﻿// <auto-generated />
using System;
using BooksApp_Sec02.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksApp_Sec02.Migrations
{
    [DbContext(typeof(BooksDBContext))]
    [Migration("20231205235003_addingRatingsCol")]
    partial class addingRatingsCol
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BooksApp_Sec02.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            Author = "Salman Nazir",
                            DatePublished = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This has no description",
                            Genre = "Coding",
                            Price = 19.99m,
                            Ratings = 0,
                            Title = "C# for Beginners"
                        },
                        new
                        {
                            BookID = 2,
                            Author = "Adam Freeman",
                            DatePublished = new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This has no description",
                            Genre = "Coding",
                            Price = 59.99m,
                            Ratings = 0,
                            Title = "Advanced C#"
                        },
                        new
                        {
                            BookID = 3,
                            Author = "Morgan Freeman",
                            DatePublished = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This has no description",
                            Genre = "Coding",
                            Price = 15.99m,
                            Ratings = 0,
                            Title = "HTML for Beginners"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
