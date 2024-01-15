using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Models.ShopModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HW_cookie_autentification.Controllers
{
    [Authorize(Roles = "orders,admin")]
    public class OrdersController : Controller
    {
        private readonly IRepository<Order> _repository;
        public OrdersController(IRepository<Order> repository)
        {
            _repository = repository;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var order = await _repository.GetDetails(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public async Task<IActionResult> Create()
        {
            var items = await _repository.GetAll();
            ViewData["ClientId"] = new SelectList(items, "Id", "Id");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,Id,Create,Modify")] Order order)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(order);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(await _repository.GetAll(), "Id", "Id", order.ClientId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var order = await _repository.GetDetails(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(await _repository.GetAll(), "Id", "Id", order.ClientId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,Id,Create,Modify")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _repository.Update(order);


                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(await _repository.GetAll(), "Id", "Id", order.ClientId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var order = await _repository.GetDetails(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_repository == null)
            {
                return Problem("Entity set 'ShopDbContext.Orders'  is null.");
            }
            await _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
