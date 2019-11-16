using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Jawla.DAL.Infrastructure;
using Jawla.Domain.Dto;
using Jawla.Domain.Interfaces;

namespace Jawla.DAL.Repositories
{
    public class AccountRepository : Repository<Account> , IAccountRepository
    {
        public AccountRepository(Context.JawlaContext Repository)
        : base(Repository)
        {
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await FindAll(); 
        }
    }
}
