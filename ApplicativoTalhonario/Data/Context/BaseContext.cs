using ApplicativoTalhonario.models;
using Microsoft.EntityFrameworkCore;

namespace ApplicativoTalhonario.Data.Context;

public class BaseContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    
    public DbSet<Offender> Offenders { get; set; }

    public BaseContext(DbContextOptions<BaseContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasKey(client => client.id);
        modelBuilder.Entity<Offender>()
            .HasKey(offender => offender.id);
        
        base.OnModelCreating(modelBuilder);
    }
}