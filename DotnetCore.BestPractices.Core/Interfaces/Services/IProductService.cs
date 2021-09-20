using DotnetCore.BestPractices.Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Interfaces.Services
{
    public interface IProductService : IServiceGeneric<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
        bool ControlInnerBarcode(string innerBarcode);
    }
}
