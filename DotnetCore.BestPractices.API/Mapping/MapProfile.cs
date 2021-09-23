using AutoMapper;
using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.DTO.Dtos.CategoryDtos;

namespace DotnetCore.BestPractices.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        }
    }
}
