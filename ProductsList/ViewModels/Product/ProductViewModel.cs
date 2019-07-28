using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsList.ViewModels.Category;

namespace ProductsList.ViewModels
{
	public class ProductViewModel
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public CategoryViewModel Category { get; set; }
	}
}
