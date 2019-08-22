using System.Collections.Generic;
using System.Threading.Tasks;
using RepositoryPattern.Common.Enities;

namespace RepositoryPattern.Repository.Interface
{
    /// <summary>
    /// Interface ICustomerRepository
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// 新增 Customer
        /// </summary>
        /// <param name="customer">實體</param>
        Task<bool> Add(Customer customer);

        /// <summary>
        /// 刪除 Customer
        /// </summary>
        /// <param name="customer">實體</param>
        Task<bool> Delete(Customer customer);

        /// <summary>
        /// 取得所有 Customer
        /// </summary>
        /// <param name="dto">查詢條件</param>
        Task<IEnumerable<Customer>> Get(QueryCustomer dto);

        /// <summary>
        /// 更新 Customer
        /// </summary>
        /// <param name="customer">實體</param>
        Task<bool> Update(Customer customer);
    }
}