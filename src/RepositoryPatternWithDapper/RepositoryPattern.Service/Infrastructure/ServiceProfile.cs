using AutoMapper;
using RepositoryPattern.Common.Dto;
using RepositoryPattern.Common.Enities;

namespace RepositoryPattern.Service.Infrastructure
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
            this.CreateMap<QueryCustomerDto, QueryCustomer>();
            this.CreateMap<Customer, CustomerDto>();
        }
    }
}