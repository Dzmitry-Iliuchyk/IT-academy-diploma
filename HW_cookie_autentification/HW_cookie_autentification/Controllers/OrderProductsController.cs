using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Models.ShopModels;
using Microsoft.AspNetCore.Mvc;

namespace HW_cookie_autentification.Controllers
{
    public class OrderProductsController : Controller
    {
        private readonly IRepository<OrderProduct> _repository;

        public OrderProductsController(IRepository<OrderProduct> repository)
        {
            _repository = repository;
        }

        // GET: OrderProducts
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
        }

        // GET: OrderProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var orderProduct = await _repository.GetDetails(id.Value);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

        // GET: OrderProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,OrderId,Id,Create,Modify")] OrderProduct orderProduct)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(orderProduct);
                return RedirectToAction(nameof(Index));
            }
            return View(orderProduct);
        }

        // GET: OrderProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var orderProduct = await _repository.GetDetails(id.Value);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

        // POST: OrderProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,OrderId,Id,Create,Modify")] OrderProduct orderProduct)
        {
            if (id != orderProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repository.Update(orderProduct);
                return RedirectToAction(nameof(Index));
            }

            return View(orderProduct);
        }

        // GET: OrderProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _repository == null)
            {
                return NotFound();
            }

            var orderProduct = await _repository.GetDetails(id.Value);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

        // POST: OrderProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_repository == null)
            {
                return Problem("Entity set 'ShopDbContext.OrderProducts'  is null.");
            }
            await _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
