using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeCinema.Data.Configurations;

namespace HomeCinema.Data.UnitOfWork
{
    public class DbFactory : Disposable, IDbFactory
    {
        HomeCinemaContext dbContext;

        public HomeCinemaContext Init()
        {
            return dbContext ?? (dbContext = new HomeCinemaContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
