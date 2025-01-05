using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses;
using SQWebService.Models.Vessels.Weapons.DefensiveWeapons.WeaponClasses;


namespace SQWebService.Models.Vessels.Weapons
{
    public class WeaponCommon
    {

        public const string EVEN_DAMAGE_TYPE = "Roll D6: Hits on evens (2,4,6)";
        public const string GUARANTEE_DAMAGE_TYPE = "Guaranteed Hit";
        public const string CRAM_DESC = "Every C-RAM on board your ship increases the amount of missiles required to do damage.";
        public const string ANTI_AIR_DESC = "Each anti aircraft weapon on your ship can target separately. Does 1 armor damage.";
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
                case "S2": return new S2();
                case "S3": return new S3();
                case "M1": return new M1();
                case "M2": return new M2();
                case "M3": return new M3();
                case "L1": return new L1();
                case "L2": return new L2();
                case "W1": return new W1();
                case "W2": return new W2();
                case "D1": return new D1();
                case "D2": return new D2();
                default: throw new Exception("No such shorthand: " + Shorthand);
            }

        }
    }
}
