namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>M3 shorthand represents the Medium Anti-Ship Missile Pod</summary
    public class M3 : IOffensiveWeapon
    {
        public string Name => "Medium Anti-Ship Missile Pod";

        public string Shorthand { get => "M3"; }
        public char Size { get => 'M'; }
        public int Range { get => 18; }
        public int CloseRange { get => 0; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.EVEN_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
