using System;
using Microsoft.EntityFrameworkCore;
using Shofy_Crud.Models;

namespace Shofy_Crud.Data
{
	public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                       .HasData(
            new Category
            {
                Id = 1,
                Name = "Headphones",
                Image = "cate-1.png"
            },

            new Category
            {
                Id = 2,
                Name = "Mobile Tablets",
                Image = "cate-2.png"
            },

            new Category
            {
                Id = 3,
                Name = "CPU Heat Pipes",
                Image = "cate-3.png"
            },

            new Category
            {
                Id = 4,
                Name = "Smart Watch",
                Image = "cate-4.png"
            },

            new Category
            {
                Id = 5,
                Name = "Bluetooth",
                Image = "cate-5.png"
            }
          );

        }
    }
}

