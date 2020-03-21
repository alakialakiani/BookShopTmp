using BookShopTmp.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopTmp.Models;

namespace BookShopTmp.Models
{
    public class BookShopContext : DbContext
    {
		//      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//      {
		//	optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=BookShopDB;User Id=sa;Password=123;");
		//}

		public BookShopContext(DbContextOptions<BookShopContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Author_BookMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new Order_BookMap());
            modelBuilder.ApplyConfiguration(new Book_TranslatorMap());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Provice> Provices { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
        public DbSet<Order_Book> Order_Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookShopTmp.Models.Translator> Translator { get; set; }
    }
}
