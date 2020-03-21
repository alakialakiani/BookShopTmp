using BookShopTmp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopTmp.Models.ViewModels
{
    public class TranslatorsCreateViewModel
    {
        public int TranslatorID { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است")]
        public string Family { get; set; }
    }
}
