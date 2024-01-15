using HW_cookie_autentification.Models.ShopModels;
using Microsoft.EntityFrameworkCore;

namespace HW_cookie_autentification.DataAccess
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ProductType>().HasData(new List<ProductType>
            {
                new ProductType
                {
                    Id = 1,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Oils"
                },
                new ProductType
                {
                    Id = 2,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Food"
                },
                new ProductType
                {
                    Id = 3,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Water"
                }
            });

            modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Pavel"
                },
                new Client
                {
                    Id = 2,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Vitaliy"
                },
                new Client
                {
                    Id = 3,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Dmitry"
                    
                }
            });

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Oil",
                    ProductTypeId=1
                },
                new Product
                {
                    Id = 2,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Butter",
                    ProductTypeId=2
                },
                new Product
                {
                    Id = 3,
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    Name="Bread",
                    ProductTypeId=2

                }
            });
            modelBuilder.Entity<Order>().HasData(new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Name = "Order 1",
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    ClientId=1
                },
                new Order
                {
                    Id = 2,
                    Name = "Order 2",
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    ClientId=2
                },
                new Order
                {
                    Id = 3,
                    Name = "Order 3",
                    Create=DateTime.Now,
                    Modify=DateTime.Now,
                    ClientId=2
                }
            });

            modelBuilder.Entity<OrderProduct>().HasData(new List<OrderProduct>
            {
                new OrderProduct
                {Id = 1,
                    OrderId = 1,
                    ProductId = 1
                },
                new OrderProduct
                {
                    Id =2,
                    OrderId = 2,
                    ProductId = 2
                },
                new OrderProduct
                {
                    Id =3,
                    OrderId = 3,
                    ProductId = 3
                }
            });
            modelBuilder.Entity<Product>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<OrderProduct>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Order>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Order>()
                .Property(p => p.ClientId)
                .HasColumnName(nameof(Order.ClientId))
                .IsRequired(true);

            //Product with ProductType
            modelBuilder.Entity<Product>()
                .HasOne(c => c.ProductType)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.ProductTypeId);

            //Order with Client
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Client)
                .WithMany(c => c.Orders)
                .HasForeignKey(c => c.ClientId);

            //Many Orders to many Products 
            modelBuilder.Entity<OrderProduct>()
                .HasOne(c => c.Order)
                .WithMany(c => c.OrderProducts)
                .HasForeignKey(c => c.OrderId);
            modelBuilder.Entity<OrderProduct>()
                .HasOne(c => c.Product)
                .WithMany(c => c.OrderProduct)
                .HasForeignKey(c => c.ProductId);

        }
    }
}
