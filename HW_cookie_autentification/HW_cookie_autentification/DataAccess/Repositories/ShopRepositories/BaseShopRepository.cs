using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Exceptions;
using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess.Repositories.Shop
{
    public class BaseShopRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ShopDbContext _dbContext;
        private readonly DbSet<T> _table;
        public BaseShopRepository(ShopDbContext shopDbContext)
        {
            _dbContext = shopDbContext;
            _table = shopDbContext.Set<T>();
        }

        virtual public async Task Create(T entity)
        {
            await _table.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        virtual public async Task Delete(int id)
        {
            var entity = await _table.FindAsync(id);
            if (entity == null)
            {
                throw new Exception("Нет такого объекта");
            }
            _table.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        virtual public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task Update(T entity)
        {
            var UpdateEntity = await _table.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==entity.Id);
            if (UpdateEntity == null)
            {
                throw new Exception("Нет такого объекта");
            }
            _table.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        virtual public async Task<T> GetDetails(int id)
        {
            return (await _table
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id))!;
        }
    }
}
