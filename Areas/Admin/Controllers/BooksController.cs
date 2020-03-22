using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopTmp.Models;
using BookShopTmp.Models.Repository;
using BookShopTmp.Models.ViewModels;
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
            var Categories = (from c in _context.Categories
                              where (c.ParentCategoryId == null)
                              select new TreeViewCategory { CategoryId = c.CategoryId, CategoryName = c.CategoryName }).ToList();
            foreach (var item in Categories)
            {
                _repository.BindSubCategories(item);
            }

            ViewBag.LanguageId = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewBag.PublisherId = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            ViewBag.AuthorId = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorId = t.AuthorId, NameFamily = t.FirstName + " " + t.LastName }), "AuthorId", "NameFamily");
            ViewBag.TranslatorId = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorId = t.TranslatorId, NameFamily = t.Name + " " + t.Family }), "TranslatorId", "NameFamily");

            BooksCreateViewModel viewModel = new BooksCreateViewModel(Categories);
            return View(viewModel);
        }
    }
}