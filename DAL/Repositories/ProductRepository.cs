using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
	class ProductRepository : Repository<Product>
	{
		public ProductRepository(ApplicationContext dbContext)
			: base(dbContext)
		{ }
	}
}
