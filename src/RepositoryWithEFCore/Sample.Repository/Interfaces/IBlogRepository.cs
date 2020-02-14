using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Repository.Enities;

namespace Sample.Repository.Interfaces
{
    /// <summary>
    /// Interface IBlogRepository
    /// </summary>
    public interface IBlogRepository
    {
        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blog">實體</param>
        Task<bool> AddAsync(Blog blog);

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="condition">查詢條件</param>
        Task<IEnumerable<Blog>> GetAsync(BlogQuery condition);

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="id">blog id</param>
        Task<bool> RemoveAsync(int id);

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blog">實體</param>
        Task<bool> UpdateAsync(Blog blog);
    }
}