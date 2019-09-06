using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sample.Repository.Interface
{
    /// <summary>
    /// Interface Repository
    /// </summary>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">實體</param>
        void Add(TEntity entity);

        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        Task<ICollection<TEntity>> GetAllAsync();

        /// <summary>
        /// 取得單筆
        /// </summary>
        /// <param name="predicate">查詢條件</param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity">實體</param>
        void Remove(TEntity entity);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">實體</param>
        void Update(TEntity entity);
    }
}