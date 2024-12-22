namespace SQWebService.Models.Vessels.Weapons.DefensiveWeapons
{
    public interface IDefensiveWeapon : IWeapon
    {
        string Name { get; set; }
        string ShortHand { get; set; }
    }
}
