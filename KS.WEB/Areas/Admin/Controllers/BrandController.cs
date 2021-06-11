using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Brand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandRepository _brandRepository;

        public BrandController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        // GET
        public IActionResult Index()
        {
            var brandListing = _brandRepository.GetAll()
                .Select(x => new BrandIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                });

            return View(brandListing);
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post(BrandIndexViewModel model)
        {
            var brand = new Brand
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            await _brandRepository.AddAsync(brand);

            TempData["SM"] = "Вы успешно создали.";
            return RedirectToAction("Index", "Brand");
        }

        public async Task<IActionResult> Put(int id, BrandIndexViewModel model)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            model.Name = brand.Name;
            model.Description = brand.Description;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Put(BrandIndexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var brand = new Brand
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };

            await _brandRepository.UpdateAsync(brand);
            TempData["SM"] = "Вы успешно изменили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            await _brandRepository.DeleteAsync(brand);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Get(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            var model = new BrandIndexViewModel
            {
                Id = brand.Id,
                Name = brand.Name,
                Description = brand.Description
            };

            return View(model);
        }
    }
}