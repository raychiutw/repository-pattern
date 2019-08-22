using AutoMapper;
using RepositoryPattern.Common.Dto;
using RepositoryPattern.WebApi.Controllers.Parameters;
using RepositoryPattern.WebApi.Controllers.ViewModels;

namespace RepositoryPattern.WebApi.Infrastructure
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
            this.CreateMap<QueryCustomerParameter, QueryCustomerDto>();
            this.CreateMap<CustomerDto, CustomerViewModel>();
        }
    }
}