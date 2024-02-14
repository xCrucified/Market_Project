using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using data_access.Data.Entities;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile(IFileService fileService)
        {
            CreateMap<ProductDto, Product>()
                .ForMember(x => x.Categories, opt => opt.Ignore());
            CreateMap<Product, ProductDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<CreateProductModel, Product>()
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(src => fileService.SaveProductImage(src.Image).Result));
        }
    }
}
