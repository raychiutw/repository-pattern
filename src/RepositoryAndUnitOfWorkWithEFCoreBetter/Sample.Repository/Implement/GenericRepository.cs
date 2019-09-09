using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        private readonly DbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">db context.</param>
        public GenericRepository(DbContext context)
        {
            this._context = context;
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

            _context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await this._context.Set<TEntity>().ToListAsync();
        }

        /// <summary>
        /// 取得單筆
        /// </summary>
        /// <param name="predicate">查詢條件</param>
        /// <returns></returns>
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await this._context.Set<TEntity>().FirstOrDefaultAsync(predicate);
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

            this._context.Entry(entity).State = EntityState.Deleted;
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

            this._context.Entry(entity).State = EntityState.Modified;
        }
    }
}