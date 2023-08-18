using Microsoft.EntityFrameworkCore;
using Pay.Data.DatabaseContext;
using Pay.Data.Infrestructure;
using Pay.Data.Models;
using Pay.Data.Repositories.Interface;

namespace Pay.Data.Repositories.Repo
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DbContext _db;
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
            _db = (_db ?? (PayDbContext)_db);
        }

    }
}
