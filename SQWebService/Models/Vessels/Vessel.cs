using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;

namespace SQWebService.Models.Vessels
{
    public class Vessel
    {
        int Id { get; set; }
        int vesselClass { get; set; }
        int engineCount { get; set; }
        int sensorRange { get; set; }
        int armor {  get; set; }
        List<IOffensiveWeapon> OffensiveWeapons { get; set; }
        List<IDefensiveWeapon> DefensiveWeapons { get; set; }



    }
}
