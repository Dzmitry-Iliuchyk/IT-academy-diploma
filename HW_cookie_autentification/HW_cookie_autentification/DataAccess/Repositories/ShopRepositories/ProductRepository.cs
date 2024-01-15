using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.Shop
{
    public class ProductRepository : BaseShopRepository<Product>
    {

        public ProductRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {

        }
        override async public Task<IEnumerable<Product>> GetAll()
        {
            return await _dbContext.Products
                 .Include(x => x.ProductType)
                 .AsNoTracking()
                 .ToListAsync();
        }
        override async public Task<Product> GetDetails(int id)
        {
            return (await _dbContext.Products
                .Include(x => x.ProductType)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id))!;
        }

    }
}
