namespace cosmonautica_v2.Dtos;

public class Position
{
    public double satlatitude { get; set; }
    public double satlongitude { get; set; }
    public double sataltitude { get; set; }
    public double azimuth { get; set; }
    public double elevation { get; set; }
    public double ra { get; set; }
    public double dec { get; set; }
    public int timestamp { get; set; }
    public bool eclipsed { get; set; }
}