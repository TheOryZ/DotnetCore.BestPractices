using DotnetCore.BestPractices.Core.Entites.Interfaces;
using DotnetCore.BestPractices.Core.Interfaces.Repositories;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.Core.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Service.Services
{
    public class GenericService<TEntity> : IServiceGeneric<TEntity> where TEntity : class, ITable, new()
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryGeneric<TEntity> _repositoryGeneric;

        public GenericService(IUnitOfWork unitOfWork, IRepositoryGeneric<TEntity> repositoryGeneric)
        {
            _repositoryGeneric = repositoryGeneric;
            _unitOfWork = unitOfWork;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repositoryGeneric.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repositoryGeneric.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repositoryGeneric.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repositoryGeneric.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _repositoryGeneric.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _repositoryGeneric.RemoveRange(entities);
            _unitOfWork.Commit();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repositoryGeneric.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _repositoryGeneric.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repositoryGeneric.WhereAsync(predicate);
        }
    }
}
