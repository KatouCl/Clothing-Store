using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET
        public IActionResult Index()
        {
            var categoryListings = _categoryRepository.GetAll()
                .Select(x => new CategoryIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug
                });

            return View(categoryListings);
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryIndexViewModel model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name,
                Slug = model.Slug
            };
            await _categoryRepository.AddAsync(category);
            TempData["SM"] = "Вы успешно создали.";
            
            return RedirectToAction("Index", "Category");
        }

        public async Task<IActionResult> Put(int id, CategoryIndexViewModel model)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            model.Name = category.Name;
            model.Slug = category.Slug;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Put(CategoryIndexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var category = new Category
            {
                Id = model.Id,
                Name = model.Name,
                Slug = model.Slug
            };

            await _categoryRepository.UpdateAsync(category);
            TempData["SM"] = "Вы успешно изменили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryRepository.DeleteAsync(category);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            var model = new CategoryIndexViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug
            };

            return View(model);
        }
    }
}