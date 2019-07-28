using AutoMapper;

namespace ProductsList.IoC
{
	public static class MapperBootstrapper
	{
		public static void Bootstrap(IMapperConfigurationExpression cfg)
		{
			BLL.IoC.MapperBootstrapper.Bootstrap(cfg);
		}
	}
}
