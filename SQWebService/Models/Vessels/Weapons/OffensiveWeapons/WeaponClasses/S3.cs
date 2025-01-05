namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>S3 shorthand represents the Small Anti-Ship Missile Pod</summary
    public class S3 : IOffensiveWeapon
    {
        public string Name => "Small Anti-Ship Missile Pod";

        public string Shorthand { get => "S3"; }
        public char Size { get => 'S'; }
        public int Range { get => 18; }
        public int CloseRange { get => 0; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
