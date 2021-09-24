using AutoMapper;
using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.DTO.Dtos.CategoryDtos;
using DotnetCore.BestPractices.DTO.Dtos.ProductDtos;

namespace DotnetCore.BestPractices.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Categories mapping
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductDto>().ReverseMap();
            #endregion

            #region Products mapping
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>().ReverseMap();
            #endregion
        }
    }
}
