using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.Repository.Infrastructure.UnitOfWork;
using Sample.Repository.Interface;

namespace Sample.Repository.Implement
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Sample.Repository.Interface.IGenericRepository{TEntity}" />
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// UnitOfWork 實體
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="unitofwork">The unitofwork.</param>
        public GenericRepository(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">實體</param>
        /// <exception cref="ArgumentNullException">entity</exception>
        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _unitOfWork.Context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await this._unitOfWork.Context.Set<TEntity>().ToListAsync();
        }

        /// <summary>
        /// 取得單筆
        /// </summary>
        /// <param name="predicate">查詢條件</param>
        /// <returns></returns>
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await this._unitOfWork.Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity">實體</param>
        /// <exception cref="ArgumentNullException">entity</exception>
        public void Remove(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            this._unitOfWork.Context.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">實體</param>
        /// <exception cref="ArgumentNullException">entity</exception>
        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            this._unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }
    }
}