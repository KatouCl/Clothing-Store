using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ProductController(
            IProductRepository productRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Get(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            var model = new ProductIndexViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Slug = product.Slug,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                Specification = product.Specification,
                OldPrice = product.OldPrice,
                Price = product.Price,
                SpecialPrice = product.SpecialPrice,
                SpecialPriceStart = product.SpecialPriceStart,
                SpecialPriceEnd = product.SpecialPriceEnd,
                IsFeatured = product.IsFeatured,
                IsCallForPricing = product.IsCallForPricing,
                IsAllowToOrder = product.IsAllowToOrder,
                CategoryIds = product.Categories.Select(x => x.CategoryId).ToList(),
                BrandId = product.BrandId,
                TaxClassId = product.TaxClassId,
                StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                CoverImageUrl = product.CoverImageUrl,
                GenderType = product.GenderType,
                UnitType = product.UnitType
            };

            return View(model);
        }

        public IActionResult Index()
        {
            var productListing = _productRepository.GetAll()
                .Select(x => new ProductIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Specification = x.Specification,
                    OldPrice = x.OldPrice,
                    Price = x.Price,
                    SpecialPrice = x.SpecialPrice,
                    SpecialPriceStart = x.SpecialPriceStart,
                    SpecialPriceEnd = x.SpecialPriceEnd,
                    IsFeatured = x.IsFeatured,
                    IsCallForPricing = x.IsCallForPricing,
                    IsAllowToOrder = x.IsAllowToOrder,
                    CategoryIds = x.Categories.Select(c => c.CategoryId).ToList(),
                    BrandId = x.BrandId,
                    TaxClassId = x.TaxClassId,
                    StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                    GenderType = x.GenderType,
                    UnitType = x.UnitType,
                    CoverImageUrl = x.CoverImageUrl
                });

            return View(productListing);
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductIndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.CoverImage != null)
                {
                    var folder = "Images/Product/";
                    model.CoverImageUrl = await UploadImage(folder, model.CoverImage);
                }

                var product = new Product
                {
                    Id = model.Id,
                    Name = model.Name,
                    Slug = model.Slug,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    Specification = model.Specification,
                    Price = model.Price,
                    OldPrice = model.OldPrice,
                    SpecialPrice = model.SpecialPrice,
                    SpecialPriceStart = model.SpecialPriceStart,
                    SpecialPriceEnd = model.SpecialPriceEnd,
                    IsFeatured = model.IsFeatured,
                    IsCallForPricing = model.IsCallForPricing,
                    IsAllowToOrder = model.IsAllowToOrder,
                    BrandId = model.BrandId,
                    TaxClassId = model.TaxClassId,
                    StockTrackingIsEnabled = model.StockTrackingIsEnabled,
                    CoverImageUrl = model.CoverImageUrl,
                    GenderType = model.GenderType,
                    UnitType = model.UnitType
                };


                foreach (var categoryId in model.CategoryIds)
                {
                    var productCategory = new ProductCategory
                    {
                        CategoryId = categoryId
                    };
                    product.AddCategory(productCategory);
                }


                await _productRepository.AddAsync(product);

                TempData["SM"] = "Вы успешно создали.";
                return RedirectToAction("Index", "Product");
            }

            return View(model);
        }

        public async Task<IActionResult> Put(int id, ProductIndexViewModel model)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
        
            model.Name = product.Name;
            model.Slug = product.Slug;
            model.ShortDescription = product.ShortDescription;
            model.Description = product.Description;
            model.Specification = product.Specification;
            model.Price = product.Price;
            model.OldPrice = product.OldPrice;
            model.SpecialPrice = product.SpecialPrice;
            model.SpecialPriceStart = product.SpecialPriceStart;
            model.SpecialPriceEnd = product.SpecialPriceEnd;
            model.IsFeatured = product.IsFeatured;
            model.IsCallForPricing = product.IsCallForPricing;
            model.IsAllowToOrder = product.IsAllowToOrder;
            model.BrandId = product.BrandId;
            model.TaxClassId = product.TaxClassId;
            model.StockTrackingIsEnabled = product.StockTrackingIsEnabled;
            model.CoverImageUrl = product.CoverImageUrl;
            model.GenderType = product.GenderType;
            model.UnitType = product.UnitType;
        
            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Put(ProductIndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.CoverImage != null)
                {
                    var folder = "Images/Product/";
                    model.CoverImageUrl = await UploadImage(folder, model.CoverImage);
                }

                var product = new Product
                {
                    Id = model.Id,
                    Name = model.Name,
                    Slug = model.Slug,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    Specification = model.Specification,
                    Price = model.Price,
                    OldPrice = model.OldPrice,
                    SpecialPrice = model.SpecialPrice,
                    SpecialPriceStart = model.SpecialPriceStart,
                    SpecialPriceEnd = model.SpecialPriceEnd,
                    IsFeatured = model.IsFeatured,
                    IsCallForPricing = model.IsCallForPricing,
                    IsAllowToOrder = model.IsAllowToOrder,
                    BrandId = model.BrandId,
                    TaxClassId = model.TaxClassId,
                    StockTrackingIsEnabled = model.StockTrackingIsEnabled,
                    CoverImageUrl = model.CoverImageUrl,
                    GenderType = model.GenderType,
                    UnitType = model.UnitType
                };

                foreach (var categoryId in model.CategoryIds)
                {
                    var productCategory = new ProductCategory
                    {
                        CategoryId = categoryId
                    };
                    product.AddCategory(productCategory);
                }


                await _productRepository.UpdateAsync(product);

                TempData["SM"] = "Вы успешно обновили товар.";
                return RedirectToAction("Index", "Product");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            await _productRepository.DeleteAsync(product);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index");
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return  folderPath;
        }
    }
}