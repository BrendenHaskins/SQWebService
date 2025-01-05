namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>L1 shorthand represents the 375mm Cannon</summary
    public class L1 : IOffensiveWeapon
    {
        public string Name => "375mm Cannon";

        public string Shorthand { get => "L1"; }
        public char Size { get => 'L'; }
        public int Range { get => 36; }
        public int CloseRange { get => 10; }
        public int Damage { get => 10; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
