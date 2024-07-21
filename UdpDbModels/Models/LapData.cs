namespace UdpDbModels.Models;

public partial class LapData
{
    public int Id { get; set; }

    public int TrackId { get; set; }

    public int CarId { get; set; }

    public double LapTime { get; set; }
}
