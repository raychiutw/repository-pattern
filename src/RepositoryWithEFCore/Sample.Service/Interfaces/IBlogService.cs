using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Service.Dtos;

namespace Sample.Service.Interfaces
{
    /// <summary>
    ///  BlogService 介面
    /// </summary>
    public interface IBlogService
    {
        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        Task<bool> AddAsync(BlogDto blogDto);

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="blogQueryDto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<BlogDto>> GetAsync(BlogQueryDto blogQueryDto);

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blogId">Blog Id</param>
        Task<bool> RemoveAsync(int blogId);

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        Task<bool> UpdateAsync(BlogDto blogDto);
    }
}