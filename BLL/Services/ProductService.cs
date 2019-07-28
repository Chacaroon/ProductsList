using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Product;
using DAL.Abstractions;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository<Product> _productRepository;
		private readonly IMapper _mapper;

		public ProductService(IRepository<Product> productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public ProductsListDTO GetAll(int page)
		{
			var productsList = new ProductsListDTO();

			var products = _productRepository.GetAll()
											 .Include(p => p.Category);

			productsList.Products = _mapper.Map<IEnumerable<ProductDTO>>(products.Skip((page - 1) * 10).Take(10));
			productsList.ProductsCount = products.Count();

			return productsList;
		}

		public void Add(AddProductDTO productDTO)
		{
			var product = _mapper.Map<Product>(productDTO);

			_productRepository.Add(product);
		}
	}
}
