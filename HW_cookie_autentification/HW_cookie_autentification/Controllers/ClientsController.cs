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
using FluentValidation;
using HW_cookie_autentification.Filters;
using Microsoft.AspNetCore.Authorization;

namespace HW_cookie_autentification.Controllers
{
    [Authorize(Roles = "admin")]
    [ClientActionFilter]
    public class ClientsController : Controller
    {
        private readonly IRepository<Client> _repository;


        public ClientsController(IRepository<Client> repository)
        {
            _repository=repository;
   
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
              return _repository != null ? 
                          View(await _repository.GetAll()) :
                          Problem("Entity set 'ShopDbContext.Clients'  is null.");
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var client = await _repository
                .GetDetails(id.Value); 
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("Name,Id,Create,Modify")] Client client)
        {
            
                await _repository.Create(client);
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var client = await _repository.GetDetails(id.Value);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,Create,Modify")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await _repository.Update(client);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var client = await _repository.GetDetails(id.Value);
                
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_repository == null)
            {
                return Problem("Entity set 'ShopDbContext.Clients'  is null.");
            }

            await _repository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
