using BackEnd.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.API.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}
