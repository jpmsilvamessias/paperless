using ApplicativoTalhonario.models;
using Microsoft.EntityFrameworkCore;

namespace ApplicativoTalhonario.Data.Context;

public class BaseContext : DbContext
{
    public DbSet<Client> Clients { get; set; }

    public BaseContext(DbContextOptions<BaseContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasKey(client => client.id);
        
        base.OnModelCreating(modelBuilder);
    }
}