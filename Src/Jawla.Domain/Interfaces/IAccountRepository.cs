using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Jawla.Domain.Dto;

namespace Jawla.Domain.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}
