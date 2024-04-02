namespace SHI_Daily_Archive.Data;
using Microsoft.EntityFrameworkCore;

public class DailyContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DailyContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Daily>().HasKey(e => e.Id);
        modelBuilder.Entity<Daily>().ToTable("Daily");
    }
    public DbSet<Daily> Dailies { get; set; }
}