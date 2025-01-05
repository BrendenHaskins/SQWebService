namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons.WeaponClasses
{
    /// <summary>W2 shorthand represents the Electromagnetic Pulse</summary
    public class W2 : IOffensiveWeapon
    {
        public string Name => "Electromagnetic Pulse";

        public string Shorthand { get => "W2"; }
        public char Size { get => 'W'; }
        public int Range { get => 10; }
        public int CloseRange { get => 0; }
        public int Damage { get => 0; }
        public string HitType { get => WeaponCommon.GUARANTEE_DAMAGE_TYPE; }
        public bool IsOverSizable { get => true; }
    }
}
