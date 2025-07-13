using Microsoft.EntityFrameworkCore;

namespace ShopingCart.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Areas.Admin.Models.Product> Products { get; set; }
    public DbSet<Areas.Admin.Models.Brand> Brands { get; set; }
    public DbSet<Areas.Admin.Models.Category> Categories { get; set; }
}