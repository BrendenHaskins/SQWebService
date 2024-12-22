namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons
{
    /// <summary>S1 shorthand represents the 75mm Cannon</summary
    public class S1 : IOffensiveWeapon
    {
        public string Name => "75mm Cannon";

        public string Shorthand { get => "S1"; }
        public char Size { get => 'S'; }
        public int Range { get => 24; }
        public int CloseRange { get => 8; }
        public int Damage { get => 2; }
        public string HitType { get => "Roll D6: Hits on evens (2,4,6)"; }
        public bool IsOverSizable { get => true; }
    }
}
