using BookShopTmp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Models.Repository
{
	public class BooksRepository
	{
		private readonly BookShopContext _context;
		public BooksRepository(BookShopContext context)
		{
			_context = context;
		}


		public List<TreeViewCategory> GetAllCategories()
		{
			var Categories = (from c in _context.Categories
							  where (c.ParentCategoryId == null)
							  select new TreeViewCategory { CategoryId = c.CategoryId, CategoryName = c.CategoryName }).ToList();
			foreach (var item in Categories)
			{
				BindSubCategories(item);
			}

			return Categories;
		}

		public void BindSubCategories(TreeViewCategory category)
		{
			var SubCategories = (from c in _context.Categories
								 where (c.ParentCategoryId == category.CategoryId)
								 select new TreeViewCategory { CategoryId = c.CategoryId, CategoryName = c.CategoryName }).ToList();
			foreach (var item in SubCategories)
			{
				BindSubCategories(item);
				category.SubCategories.Add(item);
			}
		}
	}
}
