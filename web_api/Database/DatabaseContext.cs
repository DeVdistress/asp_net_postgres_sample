using Microsoft.EntityFrameworkCore;
using web_api.Database.Models;

namespace web_api.Database;

public class DatabaseContext : DbContext
{
    public DbSet<UserMod> Users { get; set; }
    
    public DatabaseContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=здесь_указывается_пароль_от_postgres");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new web_api.Database.Configurations.UserCfg());
    }
}