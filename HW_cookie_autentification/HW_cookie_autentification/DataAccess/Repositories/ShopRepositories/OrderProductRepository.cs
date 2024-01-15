using HW_cookie_autentification.DataAccess.Repositories.Shop;
using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.ShopRepositories
{
    public class OrderProductRepository : BaseShopRepository<OrderProduct>
    {
        public OrderProductRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
        override async public Task<IEnumerable<OrderProduct>> GetAll()
        {
            return await _dbContext.OrderProducts
                 .Include(x => x.Order)
                 .Include(u => u.Product)
                 .AsNoTracking()
                 .ToListAsync();
        }
        override async public Task<OrderProduct> GetDetails(int id)
        {
            return (await _dbContext.OrderProducts
                .Include(x => x.Order)
                .Include(u => u.Product)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id))!;
        }
    }
}
