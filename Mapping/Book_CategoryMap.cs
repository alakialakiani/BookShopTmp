using BookShopTmp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Mapping
{
    public class Book_CategoryMap : IEntityTypeConfiguration<Book_Category>
    {
        public void Configure(EntityTypeBuilder<Book_Category> builder)
        {
            builder.HasKey(k => new { k.BookId, k.CategoryId });
            builder
                .HasOne(p => p.Book)
                .WithMany(t => t.Book_Categories)
                .HasForeignKey(f => f.BookId);
            builder
                .HasOne(p => p.Category)
                .WithMany(t => t.Book_Categories)
                .HasForeignKey(f => f.CategoryId);
        }
    }
}
