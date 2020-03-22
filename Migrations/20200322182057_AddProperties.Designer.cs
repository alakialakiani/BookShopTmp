﻿// <auto-generated />
using System;
using BookShopTmp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShopTmp.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20200322182057_AddProperties")]
    partial class AddProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookShopTmp.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookShopTmp.Models.Author_Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Author_Books");
                });

            modelBuilder.Entity("BookShopTmp.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Delete")
                        .HasColumnType("bit");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("image");

                    b.Property<bool?>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfPages")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Weight")
                        .HasColumnType("smallint");

                    b.HasKey("BookId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("BookInfo");
                });

            modelBuilder.Entity("BookShopTmp.Models.Book_Category", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Book_Categories");
                });

            modelBuilder.Entity("BookShopTmp.Models.Book_Translator", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("TranslatorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "TranslatorId");

                    b.HasIndex("TranslatorId");

                    b.ToTable("Book_Translator");
                });

            modelBuilder.Entity("BookShopTmp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookShopTmp.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviceProvinceId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("ProviceProvinceId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BookShopTmp.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId1")
                        .HasColumnType("int");

                    b.Property<int>("CityId2")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tell")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityId1");

                    b.HasIndex("CityId2");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookShopTmp.Models.Discount", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Percent")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("BookShopTmp.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BookShopTmp.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("AmountPaid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DispatchNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderStatusId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShopTmp.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("BookShopTmp.Models.Order_Book", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("Order_Books");
                });

            modelBuilder.Entity("BookShopTmp.Models.Provice", b =>
                {
                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provices");
                });

            modelBuilder.Entity("BookShopTmp.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BookShopTmp.Models.Translator", b =>
                {
                    b.Property<int>("TranslatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TranslatorId");

                    b.ToTable("Translator");
                });

            modelBuilder.Entity("BookShopTmp.Models.Author_Book", b =>
                {
                    b.HasOne("BookShopTmp.Models.Author", "Author")
                        .WithMany("Author_Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.Book", "Book")
                        .WithMany("Author_Books")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopTmp.Models.Book", b =>
                {
                    b.HasOne("BookShopTmp.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("BookShopTmp.Models.Book_Category", b =>
                {
                    b.HasOne("BookShopTmp.Models.Book", "Book")
                        .WithMany("Book_Categories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.Category", "Category")
                        .WithMany("Book_Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopTmp.Models.Book_Translator", b =>
                {
                    b.HasOne("BookShopTmp.Models.Book", "Book")
                        .WithMany("Book_Tranlators")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.Translator", "Translator")
                        .WithMany("book_Tranlators")
                        .HasForeignKey("TranslatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopTmp.Models.Category", b =>
                {
                    b.HasOne("BookShopTmp.Models.Category", "category")
                        .WithMany("categories")
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("BookShopTmp.Models.City", b =>
                {
                    b.HasOne("BookShopTmp.Models.Provice", "Provice")
                        .WithMany("City")
                        .HasForeignKey("ProviceProvinceId");
                });

            modelBuilder.Entity("BookShopTmp.Models.Customer", b =>
                {
                    b.HasOne("BookShopTmp.Models.City", "city1")
                        .WithMany("Customers1")
                        .HasForeignKey("CityId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.City", "city2")
                        .WithMany("Customers2")
                        .HasForeignKey("CityId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopTmp.Models.Discount", b =>
                {
                    b.HasOne("BookShopTmp.Models.Book", "Book")
                        .WithOne("Discount")
                        .HasForeignKey("BookShopTmp.Models.Discount", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopTmp.Models.Order", b =>
                {
                    b.HasOne("BookShopTmp.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("BookShopTmp.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId");
                });

            modelBuilder.Entity("BookShopTmp.Models.Order_Book", b =>
                {
                    b.HasOne("BookShopTmp.Models.Book", "Book")
                        .WithMany("Order_Books")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopTmp.Models.Order", "Order")
                        .WithMany("Order_Books")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
