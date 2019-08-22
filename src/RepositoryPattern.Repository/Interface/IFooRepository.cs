using System.Collections.Generic;
using System.Threading.Tasks;
using RepositoryPattern.Common.Enities;

namespace RepositoryPattern.Repository.Interface
{
    /// <summary>
    /// Interface IFooRepository
    /// </summary>
    public interface IFooRepository
    {
        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        Task<IEnumerable<Foo>> Get(QueryFoo dto);
    }
}