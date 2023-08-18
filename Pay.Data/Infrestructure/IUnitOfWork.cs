using Microsoft.EntityFrameworkCore;
using Pay.Data.Repositories.Repo;

namespace Pay.Data.Infrestructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        UserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
