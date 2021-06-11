using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface IUserRepository
    {
        IQueryable<ApplicationUser> GetAllQuery();
        Task<ApplicationUser> GetByIdAsync(string id);
    }
}