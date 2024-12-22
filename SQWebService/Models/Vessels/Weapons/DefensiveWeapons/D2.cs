namespace SQWebService.Models.Vessels.Weapons.DefensiveWeapons
{
    /// <summary>S1 shorthand represents the 50MM AA</summary
    public class D2 : IDefensiveWeapon
    {
        public string Name { get => "50mm AA"; }
        public string Shorthand { get => "D2"; }
        public char Size { get => 'S'; }
        public int Range { get => 6; }
        public string Description { get => "Each anti aircraft weapon on your ship can target separately. Does 1 armor damage."; }
    }
}
