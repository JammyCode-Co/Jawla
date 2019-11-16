using Jawla.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jawla.DAL.Infrastructure
{
    public class RepositoryWrapper : IRepositoryWrapper, IDisposable
    {
        private JawlaContext _repoContext;
        private bool isDisposed;

        public RepositoryWrapper(JawlaContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await _repoContext.SaveChangesAsync();
        }

        ~RepositoryWrapper()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        /// <summary>
        /// override to Dispose custom unmanaged objects
        /// </summary>
        protected virtual void DisposeCore()
        {
            if (_repoContext != null)
                _repoContext.Dispose();
        }

       

    }
}
