﻿using System.ComponentModel.DataAnnotations;

namespace BookShopTmp.Models.ViewModels
{
	public class TranslatorsCreateViewModel
	{
		public int TranslatorId { get; set; }
		[Display(Name = "نام")]
		[Required(ErrorMessage = "وارد نمودن {0} الزامی است")]
		public string Name { get; set; }

		[Display(Name = "نام خانوادگی")]
		[Required(ErrorMessage = "وارد نمودن {0} الزامی است")]
		public string Family { get; set; }
	}
}
