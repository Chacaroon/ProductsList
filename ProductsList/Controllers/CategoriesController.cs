using AutoMapper;
using BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels.Category;
using System.Collections.Generic;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;

		public CategoriesController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<CategoryViewModel>> Get()
		{
			var categoryDTOs = _categoryService.GetAll();

			return Ok(_mapper.Map<IEnumerable<CategoryViewModel>>(categoryDTOs));
		}
	}
}