using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTOs.Category;

namespace BLL.DTOs.Product
{
	public class ProductDTO
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public CategoryDTO Category { get; set; }
	}
}
