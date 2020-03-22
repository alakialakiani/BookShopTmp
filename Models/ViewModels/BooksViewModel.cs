using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Models.ViewModels
{
    public class BooksCreateViewModel
    {
        public BooksCreateViewModel(IEnumerable<TreeViewCategory> viewCategories)
        {
            Categories = viewCategories;
        }

        public BooksCreateViewModel(){}

        public IEnumerable<TreeViewCategory> Categories { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string File { get; set; }
        public int NumOfPages { get; set; }
        public short Weight { get; set; }
        public string ISBN { get; set; }
        public bool IsPublish { get; set; }
        public int LanguageId { get; set; }
        public int PublisherId { get; set; }
        public int[] AuthorId { get; set; }
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
