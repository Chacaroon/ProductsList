using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsList.ViewModels.Product
{
	public class ProductsListViewModel
	{
		public IEnumerable<ProductViewModel> Products { get; set; }
		public int ProductsCount { get; set; }
	}
}
