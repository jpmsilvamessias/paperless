using ApplicativoTalhonario.models;
using Microsoft.EntityFrameworkCore;

namespace ApplicativoTalhonario.Data.Context;

public class BaseContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    
    public DbSet<Offender> Offenders { get; set; }
    
    public DbSet<Butcher> Butchers { get; set; }

    public BaseContext(DbContextOptions<BaseContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasKey(client => client.id);
        modelBuilder.Entity<Offender>()
            .HasKey(offender => offender.id);
        modelBuilder.Entity<Butcher>()
            .HasKey(butcher => butcher.id);
        modelBuilder.Entity<Butcher>().HasOne(butcher => butcher.Offender).WithMany(offender => offender.butchers)
            .HasForeignKey(butcher => butcher.offenderId);
        modelBuilder.Entity<Butcher>().HasOne(butcher=>butcher.Client)
            .WithMany(cliente=>cliente.Butchers)
            .HasForeignKey(Butcher => Butcher.clientId);
        base.OnModelCreating(modelBuilder);
    }
}