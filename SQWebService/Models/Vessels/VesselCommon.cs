namespace SQWebService.Models.Vessels
{
    public class VesselCommon
    {
        public const int VESSEL_NON_SEED_ATTRIBUTE_COUNT = 6;
        public enum VesselClass
        {
            Aircraft = 0,
            Corvette = 1,
            Frigate = 2,
            Cruiser = 3,
            Destroyer = 4,
            Battleship = 5,
            Dreadnaught = 6
        }

        public Dictionary<string, List<string>> namingLists = new Dictionary<string, List<string>>
        {
            {"Corvette", new List<string> {"Intrepid", "Freedom", "Valor", "Scout", "Comet", "Arrow", "Falcon", "Vigilance", "Defiance", "Sentry"} },
            {"Frigate", new List<string> {"Constitution", "Independence", "Pioneer", "Discovery", "Enterprise", "Alliance", "Resolute", "Courage", "Liberty", "Frontier"} },
            {"Cruiser", new List<string> {"Ticonderoga", "Yorktown", "Gettysburg", "Antietam", "Bunker Hill", "Monterey", "Princeton", "Shiloh", "Chancellorsville", "Valley Forge"}},
            {"Destroyer", new List<string> {"Arleigh Burke", "John Paul Jones", "Paul Revere", "Lexington", "Trident", "Fury", "Chesapeake", "Protector", "Wasp", "Hornet"}},
            {"Battleship", new List<string> {"Iowa", "Texas", "Wisconsin", "Alabama", "Nevada", "South Dakota", "Tennessee", "North Carolina", "Washington", "Maine"}},
            {"Dreadnought", new List<string> {"Invincible", "Vanguard", "Warspite", "Royal Sovereign", "Victory", "Colossus", "Majestic", "Thunderer", "Conqueror", "Triumph"}}
        };

        public string GenerateName(string vesselClass)
        {
            Random rand = new Random();
            if (namingLists.TryGetValue(vesselClass, out var names) && names != null)
            {
                return names[rand.Next(names.Count)];
            } else
            {
                throw new Exception("No such vessel class: " + vesselClass);
            }
        }

        public string GenerateSeed(Vessel Vessel)
        {
            string output = "";
            output += $"{Vessel.Id},";
            output += $"{Vessel.Name},";
            output += $"{Vessel.VesselClass},";
            output += $"{Vessel.EngineCount},";
            output += $"{Vessel.SensorRange},";
            output += $"{Vessel.Armor}";

            return output;
        }

        public Vessel GenerateVessel(string Seed)
        {
            //each seed is seperated by commas, which cannot appear in any property except for the name.
            string[] propertiesArr = Seed.Split(',');
            var properties = new List<string>(propertiesArr);

            //splitting by commas may seperate names into multiple strings, combine them until count normalizes.
            while (properties.Count > VESSEL_NON_SEED_ATTRIBUTE_COUNT) {
                properties[1] = properties[1] + properties[2];
                properties.RemoveAt(2);
            }

            int[] attributeParsed = new int[VESSEL_NON_SEED_ATTRIBUTE_COUNT];

            for (int i = 0; i < properties.Count; i++)
            { 
                if (i != 1)
                {
                    attributeParsed[i] = int.Parse(properties[i]);
                }
            }

            return new Vessel(attributeParsed[0], properties[1], attributeParsed[1], attributeParsed[2], attributeParsed[3], attributeParsed[4]);
        }


    }
}
