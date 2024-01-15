using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.Shop
{
    public class ClientRepository : BaseShopRepository<Client>
    {
        
        public ClientRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
            
        }
        override async public Task<IEnumerable<Client>> GetAll()
        {
           return await _dbContext.Clients
                .Include(x=>x.Orders)
                .AsNoTracking()
                .ToListAsync();
        }
        override async public Task<Client> GetDetails(int id)
        {
            return (await _dbContext.Clients
                .Include(x=>x.Orders)
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id==id))!;
        }

    }
}
