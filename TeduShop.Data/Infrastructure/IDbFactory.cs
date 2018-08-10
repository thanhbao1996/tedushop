using System;

namespace TeduShop.Data.Infrastructure
{
    /// <summary>
    /// Giao tiep khoi tao cac doi tuong Entity
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}