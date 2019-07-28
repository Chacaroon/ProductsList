using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTOs.Product;

namespace BLL.Abstractions
{
	public interface IProductService
	{
		ProductsListDTO GetAll(int page);
		void Add(AddProductDTO productDTO);
	}
}
