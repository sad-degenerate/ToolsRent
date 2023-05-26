using Microsoft.EntityFrameworkCore;
using ToolsRent.LIB.Model.HumanModel;

namespace ToolsRent.LIB.DataBase;

public class ApplicationContext : DbContext
{
    public DbSet<IBasePassport> Passports { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientStats> ClientStats { get; set; }
    public DbSet<Human> Humans { get; set; }
    public DbSet<RentOrganization> RentOrganizations { get; set; }

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