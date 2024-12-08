using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;

namespace SQWebService.Models.Vessels
{
    /// <summary> A Non-Aircraft Vessel </summary>
    /// <param name="Id">The unique Id of this ship (e.g 001)</param>
    /// <param name="VesselClass">Class of this vessel (e.g Frigate)</param>
    /// <param name="EngineCount">Engine count (e.g 10)</param>
    /// <param name="SensorRange">Range of sensor distance (e.g 36)</param>
    /// <param name="Armor">The armor of this ship (e.g 20)</param>
    /// <param name="Armor">A string representation of the unique combonations of this ship(e.g 001_S2_10_20_16)</param>
    /// <param name="OffensiveWeapons">All offensive weapons this vessel has (e.g 2X 75 MM Cannon)</param>
    /// <param name="DefensiveWeapons">All defensive weapons this vessel has (e.g C-RAM)</param>
    public class Vessel
    {
        int Id { get; set; }
        int VesselClass { get; set; }
        int EngineCount { get; set; }
        int SensorRange { get; set; }
        int Armor {  get; set; }
        string? Seed { get; set; }
        List<IOffensiveWeapon> OffensiveWeapons { get; set; }
        List<IDefensiveWeapon> DefensiveWeapons { get; set; }



    }
}
