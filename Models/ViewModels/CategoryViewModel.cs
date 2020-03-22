using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Models.ViewModels
{
    public class TreeViewCategory
    {
        public TreeViewCategory()
        {
            SubCategories = new List<TreeViewCategory>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<TreeViewCategory> SubCategories { get; set; }
    }
}
