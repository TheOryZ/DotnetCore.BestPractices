using DotnetCore.BestPractices.Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Interfaces.Services
{
    public interface ICategoryService : IServiceGeneric<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
