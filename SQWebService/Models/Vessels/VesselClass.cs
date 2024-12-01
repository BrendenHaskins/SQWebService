namespace SQWebService.Models.Vessels
{
    public interface VesselClass
    {
        string Name { get; set; }
        int Speed { get; set; }
        int Armor { get; set; }
        int Engines { get; set; }
        int SensorRange { get; set; }

    }
}
