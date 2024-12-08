namespace SQWebService.Models.Vessels.Weapons.OffensiveWeapons
{
    /// <summary> common attributes of all offensive weapons</summary>
    /// <param name="IsOverSizable"> A weapons ability to be doubled and slotted into an oversize class slot (e.g 2X 75 MM Cannon) </param>
    public interface IOffensiveWeapon : IWeapon
    {
        bool IsOverSizable { get; }
    }
}
