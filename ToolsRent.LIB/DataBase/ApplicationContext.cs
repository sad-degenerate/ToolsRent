using Microsoft.EntityFrameworkCore;

namespace ToolsRent.LIB.DataBase;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=tools_rent;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}