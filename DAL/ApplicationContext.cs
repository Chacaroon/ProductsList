using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region DataSeeding

			modelBuilder.Entity<Category>()
						.HasData(Enumerable.Range(1, 3)
										   .Select(i => new Category {Id = i, Name = $"Category {i}"}));

			modelBuilder.Entity<Product>()
						.HasData(Enumerable.Range(1, 10)
										   .Select(i => new Product {Id = i, Name = $"Product {i}", CategoryId = (i % 3) + 1}));

			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}

}
