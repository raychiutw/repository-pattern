using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample.Repository.Enities;
using Sample.Repository.Interfaces;
using Sample.Service.Dtos;
using Sample.Service.Interfaces;

namespace Sample.Service.Implements
{
    /// <summary>
    /// BlogService
    /// </summary>
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogService"/> class.
        /// </summary>
        public BlogService(
            IBlogRepository blogRepository,
            IMapper mapper)
        {
            this._blogRepository = blogRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<bool> AddAsync(BlogDto blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Blog>(blogDto);

            return await this._blogRepository.AddAsync(blog);
        }

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="blogQueryDto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<BlogDto>> GetAsync(BlogQueryDto blogQueryDto)
        {
            // Convert BlogQueryDto to BlogQuery
            var blogQuery = this._mapper.Map<BlogQuery>(blogQueryDto);

            var blogs = await this._blogRepository.GetAsync(blogQuery);

            // Convert Blog to BlogDto
            var blogDtos = this._mapper.Map<IEnumerable<BlogDto>>(blogs);

            return blogDtos;
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blogId">Blog Id</param>
        /// <returns></returns>
        public async Task<bool> RemoveAsync(int blogId)
        {
            return await this._blogRepository.RemoveAsync(blogId);
        }

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(BlogDto blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Blog>(blogDto);

            return await this._blogRepository.UpdateAsync(blog);
        }
    }
}