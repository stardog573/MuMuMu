namespace SHI_Daily_Archive.Data;

using System.ComponentModel.DataAnnotations.Schema;
public class Daily
{
    public int Id { get; set; }
    public int Date { get; set; }
    public int FTL { get; set; }
    public int FrontArmor { get; set; }
    public int TopArmor { get; set; }
    public int BottomArmor { get; set; }
    public int Compact { get; set; }
    public int CompactX { get; set; }
    public int CompactY { get; set; }
    public int Fuel { get; set; }
    public int Thrust { get; set; }
    public int Cargo { get; set; }
    public int Radar { get; set; }
    public int Comms { get; set; }
    public int FirePower { get; set; }
    public int Passengers { get; set; }
    public int Command { get; set; }
    public double Maneuverability { get; set; }
    public int Cloaked { get; set; }
    public int ExtremeHeat { get; set; }
    public int ImportTax { get; set; }
    public int TractorBeam { get; set; }
    public int Cost { get; set; }
    public double Score = 0;
}