namespace SQWebService.Models.Vessels.Weapons.DefensiveWeapons.WeaponClasses
{
    /// <summary>S1 shorthand represents the 30mm C-RAM</summary
    public class D1 : IDefensiveWeapon
    {
        public string Name { get => "30mm C-RAM"; }
        public string Shorthand { get => "D1"; }
        public char Size { get => 'S'; }
        public int Range { get => 6; }
        public string Description { get => WeaponCommon.CRAM_DESC; }
    }
}
