using DotnetCore.BestPractices.DTO.Dtos.CategoryDtos;
using DotnetCore.BestPractices.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.DTO.Dtos.ProductDtos
{
    public class ProductWithCategoryDto : ProductListDto, IDto
    {
        public CategoryListDto Category { get; set; }
    }
}
