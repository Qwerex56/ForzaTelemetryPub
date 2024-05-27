using Microsoft.EntityFrameworkCore;

namespace UdpDbModels;

// TODO: Add connection string

public class TelemetryDbContext : DbContext {
    public DbSet<LapData> LapData { get; set; }
}