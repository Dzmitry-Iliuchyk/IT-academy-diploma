using HW_cookie_autentification.DataAccess.Repositories.Shop;
using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.ShopRepositories
{
    public class ProductTypesRepository : BaseShopRepository<ProductType>
    {
        public ProductTypesRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {

        }
        override async public Task<IEnumerable<ProductType>> GetAll()
        {
            return await _dbContext.ProductTypes
                 .Include(x => x.Products)
                 .AsNoTracking()
                 .ToListAsync();
        }
        override async public Task<ProductType> GetDetails(int id)
        {
            return (await _dbContext.ProductTypes
                .Include(x => x.Products)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id))!;
        }
    }
}
