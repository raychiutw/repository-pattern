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
        /// 取得 Blog
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<BlogDto>> Get(BlogQueryDto dto);
    }
}