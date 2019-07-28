using System;
using AutoMapper;
using BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels;
using ProductsList.ViewModels.Product;
using System.Collections.Generic;
using System.Linq;
using BLL.DTOs.Product;
using DAL.Entities;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductsController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ProductViewModel>> Get([FromQuery] int page = 1)
		{
			var productsListDto = _productService.GetAll(page);

			return Ok(_mapper.Map<ProductsListViewModel>(productsListDto));
		}

		[HttpPost]
		public ActionResult Post(AddProductViewModel model)
		{
			var product = _mapper.Map<AddProductDTO>(model);

			_productService.Add(product);

			return Ok();
		}
	}
}