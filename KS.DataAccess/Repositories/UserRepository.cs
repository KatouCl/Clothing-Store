using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KS.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<ApplicationUser> GetAllQuery()
        {
            return _context.ApplicationUsers;
        }

        public async Task<ApplicationUser> GetByIdAsync(string id)
        {
            return await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}