using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Contact;
using KS.ViewModels.FeedBack;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class HelpController : Controller
    {
        private readonly IBaseRepository<FeedBack> _feedBackRepository;
        private readonly IBaseRepository<Contact> _contactRepository;

        public HelpController(IBaseRepository<FeedBack> feedBackRepository,
            IBaseRepository<Contact> contactRepository)
        {
            _feedBackRepository = feedBackRepository;
            _contactRepository = contactRepository;
        }

        public IActionResult SizeCharts()
        {
            return View();
        }

        public IActionResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostFeedBack(FeedBackIndexVm model)
        {
            if (ModelState.IsValid)
            {
                var feedBack = new FeedBack
                {
                    Id = model.Id,
                    Name = model.Name,
                    Email = model.Email,
                    Comment = model.Comment
                };
                await _feedBackRepository.AddAsync(feedBack);

                TempData["SM"] = "Спасибо, что написали нам!";
                return RedirectToAction("FeedBack", "Help");
            }

            return RedirectToAction("FeedBack", "Help", model);
        }

        public async Task<IActionResult> Contact()
        {
            var contact = await _contactRepository.GetByIdAsync(1);
            var model = new ContactIndexVm
            {
                Id = contact.Id,
                Title = contact.Title,
                Place = contact.Place,
                Number = contact.Number,
                Context = contact.Context
            };

            return View(model);
        }

        public async Task<IActionResult> AboutUs()
        {
            var contact = await _contactRepository.GetByIdAsync(1);
            var model = new ContactIndexVm
            {
                Id = contact.Id,
                Title = contact.Title,
                Place = contact.Place,
                Number = contact.Number,
                Context = contact.Context
            };

            return View(model);
        }
    }
}