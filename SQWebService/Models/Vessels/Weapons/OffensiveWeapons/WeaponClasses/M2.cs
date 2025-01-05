namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>M2 shorthand represents the 75mm Cannon (X2)</summary
    public class M2 : IOffensiveWeapon
    {
        public string Name => "75mm Cannon (X2)";

        public string Shorthand { get => "M2"; }
        public char Size { get => 'M'; }
        public int Range { get => 24; }
        public int CloseRange { get => 8; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.EVEN_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
