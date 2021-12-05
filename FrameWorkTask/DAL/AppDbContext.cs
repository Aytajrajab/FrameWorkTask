using Microsoft.EntityFrameworkCore;
using FrameWorkTask.Models;

namespace FrameWorkTask.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Roles> Role { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Favorites> Favorite { get; set; }
        public DbSet<Baskets> Basket { get; set; }
        public DbSet<Orders> Order { get; set; }
    }
}
