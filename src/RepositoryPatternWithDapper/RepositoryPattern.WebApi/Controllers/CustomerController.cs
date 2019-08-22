using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Common.Dto;
using RepositoryPattern.Service.Interface;
using RepositoryPattern.WebApi.Controllers.Parameters;
using RepositoryPattern.WebApi.Controllers.ViewModels;

namespace RepositoryPattern.WebApi.Controllers
{
    /// <summary>
    /// CustomerController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        public CustomerController(
            ICustomerService customerService,
            IMapper mapper)
        {
            this._customerService = customerService;
            this._mapper = mapper;
        }

        /// <summary>
        /// Get Customer
        /// </summary>
        /// <param name="parameter">查詢參數</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get(QueryCustomerParameter parameter)
        {
            // Convert CustomerParameter to QuryCustomerDto
            var queryCustomerDto = this._mapper.Map<QueryCustomerDto>(parameter);

            var customerDto = await this._customerService.Get(queryCustomerDto);

            // Convert CustomerDto to CustomerViewModel
            var customerViewModels = this._mapper.Map<IEnumerable<CustomerViewModel>>(customerDto);

            return customerViewModels;
        }
    }
}