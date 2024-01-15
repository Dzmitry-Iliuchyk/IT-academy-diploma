using HW_cookie_autentification.Controllers;
using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace HW_cookie_autentification.DataAccess.Repositories.UserRepositories
{
    public class UserRepository// : IRepository<User>
    {
        private readonly UserDbContext _userDbContext;
        private readonly DbSet<User> _userDbSet;

        public UserRepository(UserDbContext dbContext)
        {
            _userDbContext = dbContext;
            _userDbSet = _userDbContext.Set<User>();
        }
        public async Task Create(User entity)
        {
            await _userDbSet.AddAsync(entity);
            await _userDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _userDbSet.FindAsync(id);
            
            _userDbSet.Remove(user);
            await _userDbContext.SaveChangesAsync();
        }

        public async Task Update(User entity)
        {
            var user = await _userDbSet.FindAsync(entity.Id);
            
            _userDbSet.Update(user);
            await _userDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await _userDbSet.AsNoTracking().ToListAsync();
            return users;
        }

        public async Task<User> GetDetails(int id)
        {
            var entity = await _userDbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            
            return entity;
        }

        public async Task<User> GetDetailsByEmail(string Email)
        {
            var entity = await _userDbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Email == Email);
            
            return entity;
        }

        
    }
}
