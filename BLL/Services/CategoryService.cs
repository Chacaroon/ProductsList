using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Category;
using DAL.Abstractions;
using DAL.Entities;
using System.Collections.Generic;

namespace BLL.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IRepository<Category> _categoryRepository;
		private readonly IMapper _mapper;

		public CategoryService(IRepository<Category> categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}

		public IEnumerable<CategoryDTO> GetAll()
		{
			var categories = _categoryRepository.GetAll();

			return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
		}
	}
}
