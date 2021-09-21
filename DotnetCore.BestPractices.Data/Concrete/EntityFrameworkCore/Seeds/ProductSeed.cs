using DotnetCore.BestPractices.Core.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id=1, Name="Dummy Product 1", Price=12.50m, Stock=100, CategoryId=_ids[0]},
                new Product { Id = 2, Name = "Dummy Product 2", Price = 10.50m, Stock = 50, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Dummy Product 3", Price = 8.50m, Stock = 75, CategoryId = _ids[1] }
                );
        }
    }
}
