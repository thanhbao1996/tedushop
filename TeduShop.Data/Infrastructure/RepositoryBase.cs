using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private TeduShopDbContext dataContext;
        private readonly IDbSet<T> dbSet;
    }
}
