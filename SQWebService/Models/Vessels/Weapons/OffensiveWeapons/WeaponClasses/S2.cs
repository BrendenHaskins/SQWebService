namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>S2 shorthand represents the 30mm Farnsworth Cannon (X4)</summary
    public class S2 : IOffensiveWeapon
    {
        public string Name => "30mm Farnsworth Cannon (X4)";

        public string Shorthand { get => "S2"; }
        public char Size { get => 'S'; }
        public int Range { get => 8; }
        public int CloseRange { get => 0; }
        public int Damage { get => 4; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
