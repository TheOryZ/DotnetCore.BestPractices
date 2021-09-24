using DotnetCore.BestPractices.DTO.Interfaces;

namespace DotnetCore.BestPractices.DTO.Dtos.ProductDtos
{
    public class ProductListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
    }
}
