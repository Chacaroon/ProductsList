using AutoMapper;
using BLL.DTOs.Product;
using DAL.Entities;

namespace BLL.IoC.Profiles
{
	public class ProductProfile : Profile
	{
		public ProductProfile()
		{
			CreateMap<AddProductDTO, Product>()
				.ForMember(p => p.Category, opt => opt.Ignore())
				.ForMember(p => p.Id, opt => opt.Ignore());
		}
	}
}
