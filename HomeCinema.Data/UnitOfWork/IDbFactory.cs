using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeCinema.Data.Configurations;

namespace HomeCinema.Data.UnitOfWork
{
    public interface IDbFactory : IDisposable
    {
        HomeCinemaContext Init();
    }
}
