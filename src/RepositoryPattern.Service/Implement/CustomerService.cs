using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RepositoryPattern.Common.Dto;
using RepositoryPattern.Common.Enities;
using RepositoryPattern.Repository.Interface;
using RepositoryPattern.Service.Interface;

namespace RepositoryPattern.Service
{
    /// <summary>
    ///
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerService"/> class.
        /// </summary>
        public CustomerService(
            ICustomerRepository customerRepository,
            IMapper mapper)
        {
            this._customerRepository = customerRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// 取得 Customer
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerDto>> Get(QueryCustomerDto dto)
        {
            // Convert QueryCustomerDto to QueyCustomer
            var queryCustomer = this._mapper.Map<QueryCustomer>(dto);

            var customer = await this._customerRepository.Get(queryCustomer);

            // Convert Customer to CustomerDto
            var customerDtos = this._mapper.Map<IEnumerable<CustomerDto>>(customer);

            return customerDtos;
        }
    }
}