using System.ComponentModel.DataAnnotations;

namespace UdpDbModels;

public class LapData {
    /// <summary>
    /// ID is also lap number
    /// </summary>
    [Key]
    public int Id { get; init; }
    
    public int TrackId { get; init; }
    public int CarId { get; init; }
    public float LapTime { get; init; }
}