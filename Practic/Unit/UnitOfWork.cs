using Practic.Infrastructure.Data;
using Practic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practic.Unit
{
    public class UnitOfWork : IDisposable
    {
        private CarOrdersContext db = new CarOrdersContext();
        EFGenericRepository<Determine> DetermineRepo = new EFGenericRepository<Determine>(new CarOrdersContext());
        EFGenericRepository<Add> AddRepo = new EFGenericRepository<Add>(new CarOrdersContext());
        EFGenericRepository<JobType> JobTypeRepo = new EFGenericRepository<JobType>(new CarOrdersContext());
        EFGenericRepository<Material> MaterialRepo = new EFGenericRepository<Material>(new CarOrdersContext());
        internal EFGenericRepository<RouteType> RouteTypeRepo = new EFGenericRepository<RouteType>(new CarOrdersContext());
        EFGenericRepository<Route> RouteRepo = new EFGenericRepository<Route>(new CarOrdersContext());
        EFGenericRepository<Weigh> WeighRepo = new EFGenericRepository<Weigh>(new CarOrdersContext());

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}