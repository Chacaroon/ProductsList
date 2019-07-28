using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTOs.Category;

namespace BLL.Abstractions
{
	public interface ICategoryService
	{
		IEnumerable<CategoryDTO> GetAll();
	}
}
