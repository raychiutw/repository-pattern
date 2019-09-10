using AutoMapper;
using Sample.Common.Dto;
using Sample.Common.Enities;

namespace Sample.Service.Infrastructure
{
    /// <summary>
    /// Class ServiceProfile.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ServiceProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProfile"/> class.
        /// </summary>
        public ServiceProfile()
        {
            this.CreateMap<Blog, BlogDto>();
            this.CreateMap<BlogQueryDto, BlogQuery>();
        }
    }
}