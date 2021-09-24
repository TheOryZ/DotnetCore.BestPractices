using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Core.Interfaces.Repositories;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.Core.Interfaces.UnitOfWorks;
using System;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Service.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepositoryGeneric<Product> repositoryGeneric) : base(unitOfWork, repositoryGeneric)
        {

        }
        public bool ControlInnerBarcode(string innerBarcode)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Product.GetWithCategoryByIdAsync(productId);
        }
    }
}
