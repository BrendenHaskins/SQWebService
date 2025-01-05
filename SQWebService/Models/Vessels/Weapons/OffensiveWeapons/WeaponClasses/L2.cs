namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>L2 shorthand represents the Large Anti-Ship Missile Pod</summary
    public class L2 : IOffensiveWeapon
    {
        public string Name => "Large Anti-Ship Missile Pod";

        public string Shorthand { get => "L2"; }
        public char Size { get => 'L'; }
        public int Range { get => 18; }
        public int CloseRange { get => 10; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
