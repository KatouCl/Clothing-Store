using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Brand;
using KS.ViewModels.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class ContactController : Controller
    {
        private readonly IBaseRepository<Contact> _contactRepository;

        public ContactController(IBaseRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IActionResult> Index()
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

        public async Task<IActionResult> Put(int id, ContactIndexVm model)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            model.Title = contact.Title;
            model.Place = contact.Place;
            model.Number = contact.Number;
            model.Context = contact.Context;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Put(ContactIndexVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var contact = new Contact
            {
                Id = model.Id,
                Title = model.Title,
                Place = model.Place,
                Number = model.Number,
                Context = model.Context
            };

            await _contactRepository.UpdateAsync(contact);
            TempData["SM"] = "Вы успешно изменили.";

            return RedirectToAction("Index");
        }
    }
}