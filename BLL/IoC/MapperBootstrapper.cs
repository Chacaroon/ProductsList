using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;
using BLL.IoC.Profiles;

namespace BLL.IoC
{
	public static class MapperBootstrapper
	{
		public static void Bootstrap(IMapperConfigurationExpression cfg)
		{
			cfg.AddProfile<ProductProfile>();
		}
	}
}
