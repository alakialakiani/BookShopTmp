using BookShopTmp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Mapping
{
    public class Book_TranslatorMap: IEntityTypeConfiguration<Book_Translator>
    {
        public void Configure(EntityTypeBuilder<Book_Translator> builder)
        {
            builder.HasKey(p => new { p.BookId, p.TranslatorId });
            builder
                .HasOne(b => b.Book)
                .WithMany(p => p.Book_Translators)
                .HasForeignKey(f => f.BookId);

            builder
              .HasOne(b => b.Translator)
              .WithMany(p => p.Book_Translators)
              .HasForeignKey(f => f.TranslatorId);

        }
    }
}
