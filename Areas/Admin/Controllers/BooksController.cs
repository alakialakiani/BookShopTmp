using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopTmp.Models.ViewModels;
using BookShopTmp.Models;
using BookShopTmp.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShopTmp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BooksController : Controller
	{
		private readonly BookShopContext _context;
		private readonly BooksRepository _repository;

		public BooksController(BookShopContext context, BooksRepository repository)
		{
			_context = context;
			_repository = repository;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			ViewBag.LanguageId = new SelectList(_context.Languages, "LanguageId", "LanguageName");
			ViewBag.PublisherId = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
			ViewBag.AuthorId = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorId = t.AuthorId, NameFamily = t.FirstName + " " + t.LastName }), "AuthorId", "NameFamily");
			ViewBag.TranslatorId = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorId = t.TranslatorId, NameFamily = t.Name + " " + t.Family }), "TranslatorId", "NameFamily");

			BooksCreateViewModel viewModel = new BooksCreateViewModel(_repository.GetAllCategories());
			return View(viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(BooksCreateViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				var authors = new List<Author_Book>();
				var translators = new List<Book_Translator>();
				var categories = new List<Book_Category>();
				DateTime? publishDate = null;
				if (viewModel.IsPublish)
					publishDate = DateTime.Now;
				var book = new Book()
				{
					Delete = false,
					ISBN = viewModel.ISBN,
					IsPublish = viewModel.IsPublish,
					NumOfPages = viewModel.NumOfPages,
					Stock = viewModel.Stock,
					Price = viewModel.Price,
					LanguageId = viewModel.LanguageId,
					Summary = viewModel.Summary,
					Title = viewModel.Title,
					PublishYear = viewModel.PublishYear,
					PublishDate = publishDate,
					Weight = viewModel.Weight,
					PublisherId = viewModel.PublisherId
				};
				await _context.Books.AddAsync(book);
				await _context.SaveChangesAsync();

				if (viewModel.AuthorId != null)
				{
					authors.AddRange(viewModel.AuthorId.Select(item => new Author_Book() {BookId = book.BookId, AuthorId = item}));

					await _context.AuthorBooks.AddRangeAsync(authors);
				}

				if (viewModel.TranslatorId != null)
				{
					translators.AddRange(viewModel.TranslatorId.Select(t => new Book_Translator() {BookId = book.BookId, TranslatorId = t}));
					await _context.BookTranslators.AddRangeAsync(translators);
				}

				if (viewModel.CategoryId != null)
				{
					categories.AddRange(viewModel.CategoryId.Select(t => new Book_Category() {BookId = book.BookId, CategoryId = t}));
					await _context.BookCategories.AddRangeAsync(categories);
				}

				await _context.SaveChangesAsync();   //Save Changes to Database
				return RedirectToAction("Index");
			}

			ViewBag.LanguageId = new SelectList(_context.Languages, "LanguageId", "LanguageName");
			ViewBag.PublisherId = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
			ViewBag.AuthorId = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorId = t.AuthorId, NameFamily = t.FirstName + " " + t.LastName }), "AuthorId", "NameFamily");
			ViewBag.TranslatorId = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorId = t.TranslatorId, NameFamily = t.Name + " " + t.Family }), "TranslatorId", "NameFamily");

			viewModel.Categories = _repository.GetAllCategories();

			return View(viewModel);
		}
	}
}
