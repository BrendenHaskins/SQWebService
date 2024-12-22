using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;

namespace SQWebService.Models.Vessels.Weapons
{
    public class WeaponCommon
    {
        enum OffensiveWeaponSizes
        {
            Aircraft = 1,
            Small = 2,
            Medium = 3,
            Large = 4,
            Super = 5

        };

        public static IWeapon GenerateWeaponFromShorthand(string Shorthand)
        {
            switch (Shorthand)
            {
                case "S1": return new S1();
                case "D1": return new D1();
                case "D2": return new D2();
                default: throw new Exception("No such shorthand: " + Shorthand);
            }

        }
    }
}
