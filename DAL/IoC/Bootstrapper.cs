using DAL.Abstractions;
using DAL.Entities;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.IoC
{
	public static class Bootstrapper
	{
		public static void Bootstrap(IServiceCollection services)
		{
			services.AddTransient<IRepository<Product>, ProductRepository>();
			services.AddTransient<IRepository<Category>, CategoryRepository>();

			services.AddTransient<IRepository<Product>, ProductRepository>();
		}
	}
}
