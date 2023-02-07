using Microsoft.EntityFrameworkCore;
using ToolsRent.BL.Model;

namespace ToolsRent.BL.DataBase;

public sealed class ApplicationContext : DbContext
{
    public DbSet<BasePassport> Passports { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientStats> ClientStats { get; set; }
    public DbSet<Human> Humans { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // TODO: перенести connectionString в app.xaml
        // TODO: удалить лишнее из Nuget (EntityFrameWork)
        const string connectionString = 
            @"Server=localhost\SQLEXPRESS;Database=tools_rent;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
        optionsBuilder.UseLazyLoadingProxies();
        
        base.OnConfiguring(optionsBuilder);
    }
}