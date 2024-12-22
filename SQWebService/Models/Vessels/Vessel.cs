using SQWebService.Models.Vessels.Weapons;
using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;

namespace SQWebService.Models.Vessels
{
    /// <summary> A Non-Aircraft Vessel </summary>
    /// <param name="Id">The unique Id of this ship (e.g 001)</param>
    /// <param name="Name">The name of the ship (e.g Screaming Eagle)</param>
    /// <param name="VesselClass">Class of this vessel (e.g Frigate)</param>
    /// <param name="EngineCount">Engine count (e.g 10)</param>
    /// <param name="SensorRange">Range of sensor distance (e.g 36)</param>
    /// <param name="Armor">The armor of this ship (e.g 20)</param>
    /// <param name="MoveDistance">The movement of this ship in inches (e.g 10)</param>
    /// <param name="Seed">A string representation of the unique combonations of this ship(e.g 001_S2_10_20_16)</param>
    /// <param name="OffensiveWeapons">All offensive weapons this vessel has (e.g 2X 75 MM Cannon)</param>
    /// <param name="DefensiveWeapons">All defensive weapons this vessel has (e.g C-RAM)</param>
    public class Vessel
    {
        public const int VESSEL_NON_SEED_ATTRIBUTE_COUNT = 9;
        public int Id { get; set; }
        public string Name { get; set; }
        public int VesselClass { get; set; }
        public int EngineCount { get; set; }
        public int SensorRange { get; set; }
        public int Armor {  get; set; }
        public int MoveDistance { get; set; }
        public string Seed { get; set; }
        public List<IOffensiveWeapon> OffensiveWeapons { get; set; }
        public List<IDefensiveWeapon> DefensiveWeapons { get; set; }

        public Vessel(int Id, string Name, int VesselClass, int EngineCount, int SensorRange, int Armor, int MoveDistance)
        {
            this.Id = Id;
            this.Name = Name;
            this.VesselClass = VesselClass;
            this.EngineCount = EngineCount;
            this.SensorRange = SensorRange;
            this.Armor = Armor;
            this.MoveDistance = MoveDistance;
            this.OffensiveWeapons = [];
            this.DefensiveWeapons = [];
            this.Seed = VesselCommon.GenerateSeed(this);
        }

        public Vessel(int Id, string Name, int VesselClass, int EngineCount, int SensorRange, int Armor, int MoveDistance,
            List<IOffensiveWeapon> OffensiveWeapons, List<IDefensiveWeapon> DefensiveWeapons)
        {
            this.Id = Id;
            this.Name = Name;
            this.VesselClass = VesselClass;
            this.EngineCount = EngineCount;
            this.SensorRange = SensorRange;
            this.Armor = Armor;
            this.MoveDistance= MoveDistance;
            this.OffensiveWeapons = OffensiveWeapons;
            this.DefensiveWeapons = DefensiveWeapons;
            this.Seed = VesselCommon.GenerateSeed(this);
        }

        public static Vessel GenerateVesselFromSeed(string Seed)
        {
            //each seed is seperated by commas, which cannot appear in any property except for the name.
            string[] propertiesArr = Seed.Split(',');
            var properties = new List<string>(propertiesArr);

            //splitting by commas may seperate names into multiple strings, combine them until count normalizes.
            while (properties.Count > VESSEL_NON_SEED_ATTRIBUTE_COUNT)
            {
                properties[1] = properties[1] + properties[2];
                properties.RemoveAt(2);
            }

            //Vessel attributes NAME and WEAPON LISTS should not be parsed
            int[] attributeParsed = new int[VESSEL_NON_SEED_ATTRIBUTE_COUNT - 2];

            for (int i = 0; i < properties.Count; i++)
            {
                if (i != 1 && i < VESSEL_NON_SEED_ATTRIBUTE_COUNT - 2)
                {
                    attributeParsed[i] = int.Parse(properties[i]);
                }
            }

            var OffensiveWeapons = new List<IOffensiveWeapon>();
            var DefensiveWeapons = new List<IDefensiveWeapon>();

            if (propertiesArr.Length == VESSEL_NON_SEED_ATTRIBUTE_COUNT)
            {
                foreach (string shorthand in propertiesArr[7].Split("-"))
                {
                    OffensiveWeapons.Add((IOffensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand(shorthand));
                }

                foreach (string shorthand in propertiesArr[8].Split("-"))
                {
                    DefensiveWeapons.Add((IDefensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand((shorthand)));
                }

                return new Vessel(attributeParsed[0], properties[1], attributeParsed[2], attributeParsed[3], attributeParsed[4], attributeParsed[5],
                                    attributeParsed[6],OffensiveWeapons, DefensiveWeapons);
            }


            return new Vessel(attributeParsed[0], properties[1], attributeParsed[2], attributeParsed[3], attributeParsed[4],
                attributeParsed[5], attributeParsed[6]);
        }
    }
}
