using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ProductDB :  IdentityDbContext
    {
        public ProductDB(DbContextOptions options) : base(options)
        {
        }

        protected ProductDB()
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
