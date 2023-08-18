using Microsoft.EntityFrameworkCore;

namespace Pay.Data.Infrestructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        void Save();
        Task<int> SaveAsync();
    }
}
