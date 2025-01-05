namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>M1 shorthand represents the 200mm Cannon</summary
    public class M1 : IOffensiveWeapon
    {
        public string Name => "200mm Cannon";

        public string Shorthand { get => "M1"; }
        public char Size { get => 'M'; }
        public int Range { get => 30; }
        public int CloseRange { get => 10; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
