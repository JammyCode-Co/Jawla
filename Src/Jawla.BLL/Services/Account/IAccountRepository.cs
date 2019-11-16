using Jawla.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Account = Jawla.Domain.Dto.Account;

namespace Jawla.BLL.Services.Account
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<IEnumerable<Jawla.Domain.Dto.Account>> GetAccounts();
    }
}
