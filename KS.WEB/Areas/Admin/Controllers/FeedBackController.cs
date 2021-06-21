using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Brand;
using KS.ViewModels.FeedBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FeedBackController : Controller
    {
        private readonly IBaseRepository<FeedBack> _feedBackRepository;

        public FeedBackController(IBaseRepository<FeedBack> feedBackRepository)
        {
            _feedBackRepository = feedBackRepository;
        }

        public IActionResult Index()
        {
            var feedBackListing = _feedBackRepository.GetAll()
                .OrderByDescending(x => x.Id)
                .Select(x => new FeedBackIndexVm
                {
                    Id = x.Id,
                    Email = x.Email,
                    Name = x.Name,
                    Comment = x.Comment[..3],
                    CreationDate = x.CreationDate
                });

            return View(feedBackListing);
        }


        public async Task<IActionResult> Get(long id)
        {
            var feedBack = await _feedBackRepository.GetByIdAsync(id);
            var model = new FeedBackIndexVm
            {
                Id = feedBack.Id,
                Email = feedBack.Email,
                Name = feedBack.Name,
                Comment = feedBack.Comment,
                CreationDate = feedBack.CreationDate
            };

            return View(model);
        }
    }
}