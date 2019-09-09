using AutoMapper;
using Sample.Common.Dto;
using Sample.WebApi.Controllers.Parameters;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Infrastructure
{
    /// <summary>
    /// Class ControllerProfile.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ControllerProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerProfile"/> class.
        /// </summary>
        public ControllerProfile()
        {
            this.CreateMap<BlogQueryParameter, BlogQueryDto>();
            this.CreateMap<BlogDto, BlogViewModel>();

            this.CreateMap<BlogDto, BlogDto>();
        }
    }
}