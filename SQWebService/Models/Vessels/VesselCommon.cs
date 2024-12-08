namespace SQWebService.Models.Vessels
{
    public class VesselCommon
    {
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
    }
}
