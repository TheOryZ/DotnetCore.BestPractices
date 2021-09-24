using DotnetCore.BestPractices.DTO.Dtos.ProductDtos;
using DotnetCore.BestPractices.DTO.Interfaces;
using System.Collections.Generic;

namespace DotnetCore.BestPractices.DTO.Dtos.CategoryDtos
{
    public class CategoryWithProductDto : CategoryListDto, IDto
    {
        public ICollection<ProductListDto> Products { get; set; }
    }
}
