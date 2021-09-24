using DotnetCore.BestPractices.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.DTO.Dtos.ProductDtos
{
    public class ProductUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string InnerBarcode { get; set; }
    }
}
