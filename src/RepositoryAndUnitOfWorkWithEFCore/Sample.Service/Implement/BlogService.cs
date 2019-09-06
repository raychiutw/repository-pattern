using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample.Common.Dto;
using Sample.Common.Enities;
using Sample.Repository.Infrastructure.UnitOfWork;
using Sample.Repository.Interface;
using Sample.Service.Interface;

namespace Sample.Service
{
    /// <summary>
    /// BlogService
    /// </summary>
    public class BlogService : IBlogService
    {
        private IGenericRepository<Blog> _blogRepository;
        private IMapper _mapper;
        private IUnitOfWork _unitofwork;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogService"/> class.
        /// </summary>
        public BlogService(
            IUnitOfWork unitofwork,
            IGenericRepository<Blog> blogRepository,
            IMapper mapper)
        {
            this._unitofwork = unitofwork;
            this._blogRepository = blogRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<int> AddAsync(BlogDto blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Blog>(blogDto);

            this._blogRepository.Add(blog);
            return await this._unitofwork.SaveChangeAsync();
        }

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="blogQueryDto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<BlogDto>> GetAsync(BlogQueryDto blogQueryDto)
        {
            var blogs = await this._blogRepository.GetAsync(x => x.BlogId == blogQueryDto.BlogId);

            // Convert Customer to CustomerDto
            var blogDtos = this._mapper.Map<IEnumerable<BlogDto>>(blogs);

            return blogDtos;
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blogId">Blog Id</param>
        /// <returns></returns>
        public async Task<int> RemoveAsync(int blogId)
        {
            var blog = await this._blogRepository.GetAsync(x => x.BlogId == blogId);

            this._blogRepository.Remove(blog);
            return await this._unitofwork.SaveChangeAsync();
        }

        /// <summary>
        /// 修改 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(BlogDto blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Blog>(blogDto);

            this._blogRepository.Update(blog);
            return await this._unitofwork.SaveChangeAsync();
        }
    }
}