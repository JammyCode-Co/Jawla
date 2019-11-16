using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jawla.Domain.Interfaces
{
    public interface IRepository<TModel> where TModel : Model
    {
        Task<IQueryable<TModel>> FindAll();
        Task<IQueryable<TModel>> FindByCondition(Expression<Func<TModel, bool>> expression);
        void Create(TModel entity);
        void Update(TModel entity);
        void Delete(TModel entity);
    }
}
