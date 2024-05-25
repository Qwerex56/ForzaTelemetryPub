using Microsoft.EntityFrameworkCore;

namespace UdpDbModels;

// TODO: Add connection string

public class TelemetryDbContext(DbContextOptions<TelemetryDbContext> options) : DbContext(options) {
    public DbSet<LapData> LapData { get; set; }
}