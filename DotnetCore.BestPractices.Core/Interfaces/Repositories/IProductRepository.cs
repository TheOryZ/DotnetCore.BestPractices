using DotnetCore.BestPractices.Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryGeneric<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
