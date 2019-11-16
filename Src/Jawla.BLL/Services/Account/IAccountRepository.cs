using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jawla.BLL.Services.Account
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Jawla.Domain.Dto.Account>> GetAccounts();
    }
}
