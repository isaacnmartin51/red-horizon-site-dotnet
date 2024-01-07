using Microsoft.EntityFrameworkCore;

namespace RedHorizonSite.Data.Database;

public class RhContext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<ShowDetails> ShowDetails { get; set; }

    public RhContext(DbContextOptions<RhContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShowDetails>().HasData(SeedData.GetShowDetailData());

        base.OnModelCreating(modelBuilder);
    }
}