using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.Shop
{
    public class OrderRepository : BaseShopRepository<Order>
    {

        public OrderRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
            
        }
        override async public Task<IEnumerable<Order>> GetAll()
        {
            return await _dbContext.Orders
                 .Include(x => x.Client)
                 .AsNoTracking()
                 .ToListAsync();
        }
        override async public Task<Order> GetDetails(int id)
        {
            return (await _dbContext.Orders
                .Include(x => x.Client)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id))!;

        }

    }
}
