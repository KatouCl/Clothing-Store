using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Brand;
using KS.ViewModels.Warehouse;
using Microsoft.AspNetCore.Mvc;

namespace KS.WebAdmin.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseController(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }
        
        public IActionResult Index()
        {
            var warehouseListitng = _warehouseRepository.GetAll()
                .Select(x => new WarehouseIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Vendor = x.Vendor
                });

            return View(warehouseListitng);
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post(WarehouseIndexViewModel model)
        {
            var warehouse = new Warehouse
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Vendor = model.Vendor
            };
            await _warehouseRepository.AddAsync(warehouse);

            TempData["SM"] = "Вы успешно создали.";
            return RedirectToAction("Index", "Warehouse");
        }

        public async Task<IActionResult> Put(int id, WarehouseIndexViewModel model)
        {
            var warehouse = await _warehouseRepository.GetByIdAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            model.Name = warehouse.Name;
            model.Address = warehouse.Address;
            model.Vendor = warehouse.Vendor;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Put(WarehouseIndexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var warehouse = new Warehouse
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Vendor = model.Vendor
            };

            await _warehouseRepository.UpdateAsync(warehouse);
            TempData["SM"] = "Вы успешно изменили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var warehouse = await _warehouseRepository.GetByIdAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            await _warehouseRepository.DeleteAsync(warehouse);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Get(int id)
        {
            var warehouse = await _warehouseRepository.GetByIdAsync(id);
            var model = new WarehouseIndexViewModel
            {
                Id = warehouse.Id,
                Name = warehouse.Name,
                Address = warehouse.Address,
                Vendor = warehouse.Vendor
            };

            return View(model);
        }

        public IActionResult Storage()
        {
            var warehouseListing = _warehouseRepository.GetAll()
                .Select(x => new WarehouseIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address
                });
            
            return View(warehouseListing);
        }
    }
}