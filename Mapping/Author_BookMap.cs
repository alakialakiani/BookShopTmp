﻿using BookShopTmp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Mapping
{
    public class Author_BookMap : IEntityTypeConfiguration<Author_Book>
    {
        public void Configure(EntityTypeBuilder<Author_Book> builder)
        {
            builder.HasKey(t => new { t.BookId, t.AuthorId });
            builder
              .HasOne(p => p.Book)
              .WithMany(t => t.Author_Books)
              .HasForeignKey(f => f.BookId);

            builder
               .HasOne(p => p.Author)
               .WithMany(t => t.Author_Books)
               .HasForeignKey(f => f.AuthorId);
        }
    }
}
