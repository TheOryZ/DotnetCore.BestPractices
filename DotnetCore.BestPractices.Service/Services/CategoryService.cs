using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Core.Interfaces.Repositories;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.Core.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepositoryGeneric<Category> repositoryGeneric) : base(unitOfWork, repositoryGeneric)
        {

        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.Category.GetWithProductsByIdAsync(categoryId);
        }
    }
}
