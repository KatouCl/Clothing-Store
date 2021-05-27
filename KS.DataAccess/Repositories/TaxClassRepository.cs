using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.TaxClass;
using Microsoft.EntityFrameworkCore;

namespace KS.DataAccess.Repositories
{
    public class TaxClassRepository : BaseRepository<TaxClass>, ITaxClassRepository
    {
        private readonly ApplicationDbContext _context;

        public TaxClassRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
        public async Task<List<TaxClassIndexViewModel>> GetTaxClass()
        {
            return await _context.TaxClasses.Select(x => new TaxClassIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Interest = x.Interest
            }).ToListAsync();
        }
    }
}