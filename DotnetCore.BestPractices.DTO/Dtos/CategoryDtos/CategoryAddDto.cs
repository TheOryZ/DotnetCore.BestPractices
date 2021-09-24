using DotnetCore.BestPractices.DTO.Interfaces;

namespace DotnetCore.BestPractices.DTO.Dtos.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        // TODO : fluentValidation ayarlamaları eklenmelidir. Name alanı zorunluluğunu kontrol edebilmemiz için. (Service katmanında.)
        public string Name { get; set; }
    }
}
