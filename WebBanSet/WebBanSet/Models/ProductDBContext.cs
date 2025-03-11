﻿using Microsoft.EntityFrameworkCore;

namespace WebBanSet.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> PI { get; set; }
    }
}
