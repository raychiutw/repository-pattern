using AutoMapper;
using Sample.Repository.Enities;
using Sample.Service.Dtos;

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
            this.CreateMap<BlogQueryDto, BlogQuery>();
            this.CreateMap<Blog, BlogDto>();
        }
    }
}