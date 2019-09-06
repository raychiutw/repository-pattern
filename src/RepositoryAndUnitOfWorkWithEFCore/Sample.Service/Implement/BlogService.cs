using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample.Common.Dto;
using Sample.Common.Enities;
using Sample.Repository.Interface;
using Sample.Service.Interface;

namespace Sample.Service
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
        /// 取得 Customer
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<BlogDto>> Get(BlogQueryDto dto)
        {
            // Convert QueryCustomerDto to QueyCustomer
            var blogQuery = this._mapper.Map<BlogQuery>(dto);

            var blogs = await this._blogRepository.Get(blogQuery);

            // Convert Customer to CustomerDto
            var blogDtos = this._mapper.Map<IEnumerable<BlogDto>>(blogs);

            return blogDtos;
        }
    }
}