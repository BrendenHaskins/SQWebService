namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>W1 shorthand represents the Directed Energy Cannon</summary
    public class W1 : IOffensiveWeapon
    {
        public string Name => "Directed Energy Cannon";

        public string Shorthand { get => "W1"; }
        public char Size { get => 'W'; }
        public int Range { get => 36; }
        public int CloseRange { get => 0; }
        public int Damage { get => 12; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
