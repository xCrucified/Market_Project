using AutoMapper;
using BusinessLogic.DTOs;
using data_access.Data.Entities;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(x => x.Categories, opt => opt.Ignore());
            CreateMap<Product, ProductDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
