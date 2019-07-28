using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
	class CategoryRepository : Repository<Category>
	{
		public CategoryRepository(ApplicationContext dbContext)
			: base(dbContext) { }
	}
}
