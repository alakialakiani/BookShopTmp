using BookShopTmp.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BookShopTmp.Models
{
	public class BookShopContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=BookShopDB;User Id=sa;Password=123;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new Author_BookMap());
			modelBuilder.ApplyConfiguration(new CustomerMap());
			modelBuilder.ApplyConfiguration(new Order_BookMap());
			modelBuilder.ApplyConfiguration(new Book_TranslatorMap());
			modelBuilder.ApplyConfiguration(new Book_CategoryMap());
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Provice> Provices { get; set; }
		public DbSet<Author_Book> AuthorBooks { get; set; }
		public DbSet<Order_Book> OrderBooks { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<Discount> Discounts { get; set; }
		public DbSet<OrderStatus> OrderStatuses { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Translator> Translator { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<Book_Category> BookCategories { get; set; }
		public DbSet<Book_Translator> BookTranslators { get; set; }
	}
}
