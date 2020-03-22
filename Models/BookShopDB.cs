using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopTmp.Models
{
    [Table("BookInfo")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string File { get; set; }
        public int NumOfPages { get; set; }
        public short Weight { get; set; }
        public string ISBN { get; set; }
        public bool? IsPublish { get; set; }
        public DateTime? PublishDate { get; set; }
        public int PublishYear { get; set; }
        public bool? Delete { get; set; }

        [Column(TypeName ="image")]
        public byte[] Image { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public Discount Discount { get; set; }
        public List<Author_Book> Author_Books { get; set; }
        public List<Order_Book> Order_Books { get; set; }
        public List<Book_Translator> Book_Tranlators { get; set; }
        public List<Book_Category> Book_Categories { get; set; }

        public Publisher Publisher { get; set; }
    }
    public class Book_Category
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }

        public Book Book { get; set; }
        public Category Category { get; set; }
    }
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public List<Book> Books { get; set; }
    }
    public class Book_Translator
    {
        public int TranslatorId { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }
        public Translator Translator { get; set; }
    }
    public class Translator
    {
        [Key]
        public int TranslatorId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public List<Book_Translator> book_Tranlators { get; set; }
    }
    public class Author_Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }
    }
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Author_Book> Author_Books { get; set; }
    }
    public class Discount
    {
        [Key,ForeignKey("Book")]
        public int BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte Percent { get; set; }

        public Book Book { get; set; }
    }
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public List<Book> Books { get; set; }
    }
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [ForeignKey("category")]
        public int? ParentCategoryId { get; set; }

        public Category category { get; set; }
        public List<Category> categories { get; set; }
        public List<Book_Category> Book_Categories { get; set; }
    }
    public class Order
    {
        public string OrderId { get; set; }
        public long AmountPaid { get; set; }
        public string DispatchNumber { get; set; }
        public DateTime BuyDate { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public Customer Customer { get; set; }
        public List<Order_Book> Order_Books { get; set; }
    }
    public class Order_Book
    {
        public string OrderId { get; set; }
        public int BookId { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }

        public List<Order> Orders { get; set; }
    }
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Mobile { get; set; }
        public string Tell { get; set; }
        public string Image { get; set; }

        public int Age { get; set; }

        public int CityId1 { get; set; }
        public int CityId2 { get; set; }

        public City city1 { get; set; }
        public City city2 { get; set; }
        public List<Order> Orders { get; set; }
    }
    public class Provice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public List<City> City { get; set; }
    }
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public Provice Provice { get; set; }
        public List<Customer> Customers1 { get; set; }
        public List<Customer> Customers2 { get; set; }
    }
}
