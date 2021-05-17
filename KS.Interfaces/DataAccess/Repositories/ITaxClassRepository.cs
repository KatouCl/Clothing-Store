using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.TaxClass;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface ITaxClassRepository: IBaseRepository<TaxClass>
    {
        Task<List<TaxClassIndexViewModel>> GetTaxClass();
    }
}