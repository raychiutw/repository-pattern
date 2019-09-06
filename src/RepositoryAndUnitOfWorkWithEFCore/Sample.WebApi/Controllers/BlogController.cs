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
        /// Get Blog
        /// </summary>
        /// <param name="parameter">查詢參數</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<BlogViewModel>> Get([FromQuery] BlogQueryParameter parameter)
        {
            // Convert BlogParameter to BlogQueryDto
            var blogQueryDto = this._mapper.Map<BlogQueryDto>(parameter);

            var blogDtos = await this._blogService.Get(blogQueryDto);

            // Convert BlogDto to BlodViewModel
            var blogViewModels = this._mapper.Map<IEnumerable<BlogViewModel>>(blogDtos);

            return blogViewModels;
        }
    }
}