using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sample.Common.Dto;
using Sample.Service.Interface;
using Sample.WebApi.Controllers.Parameters;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Controllers
{
    /// <summary>
    /// BlogController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogService _blogService;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogController"/> class.
        /// </summary>
        /// <param name="blogService">The blog service.</param>
        /// <param name="mapper">The mapper.</param>
        public BlogController(
            IBlogService blogService,
            IMapper mapper)
        {
            this._blogService = blogService;
            this._mapper = mapper;
        }

        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="parameter">Blog</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> AddAsync([FromBody] BlogParameter parameter)
        {
            // Convert BlogParameter to BlogQueryDto
            var blogDto = this._mapper.Map<BlogDto>(parameter);

            var status = await this._blogService.AddAsync(blogDto);

            return status;
        }

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="parameter">查詢參數</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<BlogViewModel>> GetAsync([FromQuery] BlogQueryParameter parameter)
        {
            // Convert BlogQueryParameter to BlogQueryDto
            var blogQueryDto = this._mapper.Map<BlogQueryDto>(parameter);

            var blogDtos = await this._blogService.GetAsync(blogQueryDto);

            // Convert BlogDto to BlodViewModel
            var blogViewModels = this._mapper.Map<IEnumerable<BlogViewModel>>(blogDtos);

            return blogViewModels;
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="id">Blog Id</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/{id}")]
        public async Task<bool> RemoveAsync(int id)
        {
            var status = await this._blogService.RemoveAsync(id);

            return status;
        }

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="parameter">Blog</param>
        /// <returns></returns>
        [HttpPatch]
        public async Task<bool> UpdateAsync([FromBody] BlogParameter parameter)
        {
            // Convert BlogParameter to BlogQueryDto
            var blogDto = this._mapper.Map<BlogDto>(parameter);

            var status = await this._blogService.UpdateAsync(blogDto);

            return status;
        }
    }
}