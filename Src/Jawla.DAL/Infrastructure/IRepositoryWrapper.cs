using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jawla.DAL.Infrastructure
{
    public interface IRepositoryWrapper
    {
        Task SaveAsync();
    }
}
