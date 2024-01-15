using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HW_cookie_autentification.DataAccess;
using HW_cookie_autentification.Models.ShopModels;
using HW_cookie_autentification.DataAccess.Repository;

namespace HW_cookie_autentification.Controllers
{
    public class ProductTypesController : Controller
    {
        private readonly IRepository<ProductType> _repository;

        public ProductTypesController(IRepository<ProductType> repository)
        {
            _repository = repository;
        }

        // GET: ProductTypes
        public async Task<IActionResult> Index()
        {
              return _repository!= null ? 
                          View(await _repository.GetAll()) :
                          Problem("Entity set '_repository(ProductType)'  is null.");
        }

        // GET: ProductTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var productType = await _repository.GetDetails(id.Value);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // GET: ProductTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,Create,Modify")] ProductType productType)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(productType);
                return RedirectToAction(nameof(Index));
            }
            return View(productType);
        }

        // GET: ProductTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var productType = await _repository.GetDetails(id.Value);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        // POST: ProductTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,Create,Modify")] ProductType productType)
        {
            if (id != productType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                    await _repository.Update(productType);
                    
                
                return RedirectToAction(nameof(Index));
            }
            return View(productType);
        }

        // GET: ProductTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var productType = await _repository.GetDetails(id.Value);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // POST: ProductTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_repository == null)
            {
                return Problem("Entity set '_repository'  is null.");
            }
            await _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
