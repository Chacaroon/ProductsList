using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ProductsList.IoC
{
	public static class Bootstrapper
	{
		public static void Bootstrap(IServiceCollection services)
		{
			BLL.IoC.Bootstrapper.Bootstrap(services);
		}
	}
}
