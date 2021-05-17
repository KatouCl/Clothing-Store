using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Brand;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        Task<List<BrandIndexViewModel>> GetBrand();
    }
}