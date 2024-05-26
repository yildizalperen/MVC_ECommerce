using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.Services.Concretes;
using ECommerce.BLL.ViewModels.SupplierViewModels;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        public IActionResult Index()
        {
            var suppliers = _supplierService.GetAllSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    Id = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SupplierViewModelUser supplierVM)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = new Supplier()
                {
                    CompanyName = supplierVM.CompanyName,
                    ContactName = supplierVM.ContactName,
                    Address = supplierVM.Address,
                    PhoneNumber = supplierVM.PhoneNumber
                };
                string result = await _supplierService.AddSupplierAsync(supplier);
                TempData["Result"] = result;

                return RedirectToAction("Index", "Supplier");
            }
            else
            {
                return View(supplierVM);
            }
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            var updated = _supplierService.GetSupplierById(id);


            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Update(Supplier supplier)
        {
            string result = await _supplierService.UpdateSupplierAsync(supplier);

            TempData["result"] = result;

            return RedirectToAction("Index", "Supplier");

        }

        public IActionResult Active()
        {
            var suppliers = _supplierService.GetActiveSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    Id = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }

        public IActionResult Passive()
        {
            var suppliers = _supplierService.GetPassiveSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    Id = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }
    }
}
