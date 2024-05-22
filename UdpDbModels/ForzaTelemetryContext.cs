using Microsoft.EntityFrameworkCore;

namespace UdpDbModels;

public partial class ForzaTelemetryContext : DbContext {
    public ForzaTelemetryContext() {
    }

    public ForzaTelemetryContext(DbContextOptions<ForzaTelemetryContext> options)
        : base(options) {
    }

    public virtual DbSet<LapData> LapData { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseNpgsql();

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<LapData>(entity => {
            entity.HasKey(e => e.Id).HasName("LapData_pkey");

            entity.Property(e => e.Id)
                  .ValueGeneratedNever()
                  .HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("carId");
            entity.Property(e => e.LapTime).HasColumnName("lapTime");
            entity.Property(e => e.TrackId).HasColumnName("trackId");
        });

    }
}