using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Category;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<List<CategoryIndexViewModel>> GetCategory();
    }
}