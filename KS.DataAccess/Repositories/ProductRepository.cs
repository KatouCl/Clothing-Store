using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using System.Linq;
using KS.ViewModels.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace KS.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public new async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.Where(x => x.Id == id)
                .Include(x => x.Categories)
                .FirstAsync();
        }
    }
}