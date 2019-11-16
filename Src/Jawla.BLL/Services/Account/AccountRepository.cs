using Jawla.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jawla.BLL.Services.Account
{
    public class AccountRepository : Repository<Jawla.Domain.Entities.Account>, IAccountRepository
    {
        private readonly IRepository<Jawla.Domain.Dto.Account> _repository;
        public AccountRepository(Context.JawlaContext Repository)
            : base(Repository)
        {
        }

        public async Task<IEnumerable<Jawla.Domain.Dto.Account>> GetAccounts()
        {
            return _repository.FindAll().Result;
        }
    }
}
