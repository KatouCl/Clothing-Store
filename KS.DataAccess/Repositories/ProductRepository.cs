using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using System.Linq;
using KS.ViewModels.Cart;
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
        public new async Task<Product> GetByIdAsync(long id)
        {
            return await _context.Products.Where(x => x.Id == id)
                .Include(x => x.Categories)
                .FirstAsync();
        }
        
        public async Task<List<CartItemVm>> GetProductsForCartAsync(IEnumerable<long> ids)
        {
            return await base.GetAllQuery()
                .Where(x => ids.Contains(x.Id))
                .Select(x => new CartItemVm
                {
                    ProductId = x.Id,
                    ProductName = x.Name,
                    Price = x.Price,
                    ImageUrl = x.CoverImageUrl
                }).ToListAsync();
        }
    }
}