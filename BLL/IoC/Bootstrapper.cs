using System;
using System.Collections.Generic;
using System.Text;
using BLL.Abstractions;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.IoC
{
	public static class Bootstrapper
	{
		public static void Bootstrap(IServiceCollection services)
		{
			services.AddTransient<IProductService, ProductService>();
			services.AddTransient<ICategoryService, CategoryService>();

			DAL.IoC.Bootstrapper.Bootstrap(services);
		}
	}
}
