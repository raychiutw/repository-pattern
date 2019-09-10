using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Common.Enities;

namespace Sample.Repository.Interface
{
    /// <summary>
    /// Interface BlogRepository
    /// </summary>
    public interface IBlogRepository
    {
        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        Task<int> AddAsync(Blog blog);

        /// <summary>
        /// 取得所有 Blog
        /// </summary>
        /// <param name="blogQuery">查詢條件</param>
        Task<IEnumerable<Blog>> GetAsync(BlogQuery blogQuery);

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        Task<int> RemoveAsync(Blog blog);

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        Task<int> UpdateAsync(Blog blog);
    }
}