using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Jawla.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jawla.Domain;
using Jawla.Domain.Interfaces;

namespace Jawla.DAL.Infrastructure
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : Model
    {
        protected JawlaContext JawlaContext { get; set; }

        public Repository(JawlaContext repositoryContext)
        {
            this.JawlaContext = repositoryContext;
        }

        public async Task<IQueryable<TModel>> FindAll()
        {
            return this.JawlaContext.Set<TModel>().AsNoTracking();
        }

        public async Task<IQueryable<TModel>> FindByCondition(Expression<Func<TModel, bool>> expression)
        {
            return this.JawlaContext.Set<TModel>().Where(expression).AsNoTracking();
        }

        public void Create(TModel entity)
        {
            this.JawlaContext.Set<TModel>().Add(entity);
        }

        public void Update(TModel entity)
        {
            this.JawlaContext.Set<TModel>().Update(entity);
        }

        public void Delete(TModel entity)
        {
            this.JawlaContext.Set<TModel>().Remove(entity);
        }
    }
}
