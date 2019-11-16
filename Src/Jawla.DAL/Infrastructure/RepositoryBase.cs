using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Jawla.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Jawla.DAL.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected JawlaContext JawlaContext { get; set; }

        public RepositoryBase(JawlaContext repositoryContext)
        {
            this.JawlaContext = repositoryContext;
        }

        public async Task<IQueryable<T>> FindAll()
        {
            return this.JawlaContext.Set<T>().AsNoTracking();
        }

        public async Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.JawlaContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.JawlaContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.JawlaContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.JawlaContext.Set<T>().Remove(entity);
        }
    }
}
