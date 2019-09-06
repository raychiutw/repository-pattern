using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Common.Dto;

namespace Sample.Service.Interface
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
        /// <returns></returns>
        Task<int> AddAsync(BlogDto blogDto);

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
        /// <returns></returns>
        Task<int> RemoveAsync(int blogId);

        /// <summary>
        /// 修改 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        Task<int> UpdateAsync(BlogDto blogDto);
    }
}