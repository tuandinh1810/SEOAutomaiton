using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SEOAutomation.Base.Models.Common;

namespace SEOAutomation.Base.Service
{
    public abstract class BaseService : IDisposable
    {
        #region Entities

        
        private DynamicSEOAutomationEntities _seoAutomationEntities;

        protected DynamicSEOAutomationEntities SeoAutomationEntities
            => _seoAutomationEntities ?? (_seoAutomationEntities = new DynamicSEOAutomationEntities());

        public void RollBackChanges(DbContext context)
        {
            var changedEntries = context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries.Where(x => x.State == EntityState.Modified))
            {
                entry.CurrentValues.SetValues(entry.OriginalValues);
                entry.State = EntityState.Unchanged;
            }

            foreach (var entry in changedEntries.Where(x => x.State == EntityState.Added))
            {
                entry.State = EntityState.Detached;
            }

            foreach (var entry in changedEntries.Where(x => x.State == EntityState.Deleted))
            {
                entry.State = EntityState.Unchanged;
            }

        }
        #endregion

        #region auto retry 3 times, used for large transactions

        /// <summary>
        ///  auto retry a function if it has error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="tryTimes"></param>
        /// <param name="waitingTimeBetween2Tries"></param>
        public void ExecuteFunction<T>(Func<T> func, int tryTimes = 3, int waitingTimeBetween2Tries = 500)
        {
            var cnt = 0;
            while (cnt <= tryTimes)
            {
                try
                {
                    cnt++;
                    //execute function
                    func();
                    return;
                }
                catch (Exception ex)
                {
                    if (cnt == tryTimes)
                    {
                        throw;
                    }
                    //retry after waitng
                    Thread.Sleep(waitingTimeBetween2Tries);
                }
            }
        }


        #endregion

        #region Dispose

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _seoAutomationEntities?.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
