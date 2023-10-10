using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TeslaShop.Domain.Models;

namespace TeslaShop.Data.DbContexts;

public class AppDbContext : DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<ProductInventory> ProductInventories { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=HP-470\\SQLEXPRESS; Database=TeslaShopDb; Trusted_Connection = True; TrustServerCertificate=True");
    }
}
