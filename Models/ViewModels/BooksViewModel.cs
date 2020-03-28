using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopTmp.Models.ViewModels
{
	public class BooksCreateViewModel
	{
		public BooksCreateViewModel(IEnumerable<TreeViewCategory> viewCategories)
		{
			Categories = viewCategories;
		}

		public BooksCreateViewModel()
		{

		}

		public IEnumerable<TreeViewCategory> Categories { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "عنوان ")]
		public string Title { get; set; }

		[Display(Name = "خلاصه")]
		public string Summary { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "قیمت")]
		public int Price { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "موجودی")]
		public int Stock { get; set; }
		public string File { get; set; }

		[Display(Name = "تعداد صفحات")]
		public int NumOfPages { get; set; }

		[Display(Name = "وزن")]
		public short Weight { get; set; }

		[Display(Name = "شابک")]
		public string ISBN { get; set; }

		[Display(Name = " این کتاب روی سایت منتشر شود.")]
		public bool IsPublish { get; set; }


		[Display(Name = "سال انتشار")]
		public int PublishYear { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "زبان")]
		public int LanguageId { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "ناشر")]
		public int PublisherId { get; set; }

		[Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
		[Display(Name = "نویسندگان")]
		public int[] AuthorId { get; set; }

		[Display(Name = "مترجمان")]
		public int[] TranslatorId { get; set; }

		public int[] CategoryId { get; set; }
	}

	public class AuthorList
	{
		public int AuthorId { get; set; }
		public string NameFamily { get; set; }
	}

	public class TranslatorList
	{
		public int TranslatorId { get; set; }
		public string NameFamily { get; set; }
	}
}
