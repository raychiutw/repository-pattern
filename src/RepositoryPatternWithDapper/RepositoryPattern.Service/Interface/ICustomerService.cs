using System.Collections.Generic;
using System.Threading.Tasks;
using RepositoryPattern.Common.Dto;

namespace RepositoryPattern.Service.Interface
{
    /// <summary>
    ///  CustomerService 介面
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// 取得 Customer
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<CustomerDto>> Get(QueryCustomerDto dto);
    }
}