
using NguyenPhiTruong_2122110563.Model;
using Microsoft.EntityFrameworkCore;
namespace NguyenPhiTruong_2122110563.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
