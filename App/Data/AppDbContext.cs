using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public class AppDbContext : DbContext
{
    public DbSet<Race> Races { get; set; }
    public DbSet<RaceResult> RaceResults { get; set; }
    public DbSet<ResultItem> ResultItem { get; set; }
    public DbSet<Vehicle> Vehicles { get; set;}
    public DbSet<VehicleCategory> VehicleCategories { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}