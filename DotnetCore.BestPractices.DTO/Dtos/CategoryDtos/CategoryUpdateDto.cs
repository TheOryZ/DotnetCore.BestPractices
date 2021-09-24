using DotnetCore.BestPractices.DTO.Interfaces;

namespace DotnetCore.BestPractices.DTO.Dtos.CategoryDtos
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
