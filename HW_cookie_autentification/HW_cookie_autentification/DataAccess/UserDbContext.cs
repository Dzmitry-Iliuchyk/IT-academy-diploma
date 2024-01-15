using HW_cookie_autentification.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess
{
    public class UserDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasData(new List<User>
                {
                    new User { Id = 1,Email="Dmitry123@mail.ru",Password="123",Role="orders",Name="Dmitry",},
                    new User { Id = 2,Email="1@mail.ru",Password="123",Role="customer",Name="DD",},
                    new User { Id = 3,Email="2@mail.ru",Password="123",Role="admin",Name="Mit",},
                    new User { Id = 4,Email="3@mail.ru",Password="123",Role="supervisor",Name="adsa",}
                });
        }
    }
}
