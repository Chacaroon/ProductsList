using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Product
{
	public class ProductsListDTO
	{
		public IEnumerable<ProductDTO> Products { get; set; }
		public int ProductsCount { get; set; }
	}
}
