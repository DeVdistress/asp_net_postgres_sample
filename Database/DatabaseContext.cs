using Microsoft.EntityFrameworkCore;
using web_api.Database.Models;

namespace web_api.Database;

public class DatabaseContext : DbContext
{
    private readonly string? _connectionString;
    
    public DbSet<UserMod> Users { get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
    : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DatabaseContext(string connectionString)
    {
        Database.EnsureCreated();
        _connectionString = connectionString;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        if(_connectionString != null)
            optionsBuilder.UseNpgsql(_connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // please read about Fluent API in and how use it in DBcontext - https://metanit.com/sharp/entityframeworkcore/2.13.php
        modelBuilder.ApplyConfiguration(new web_api.Database.Configurations.UserCfg());
    }
}