namespace SQWebService.Models.Vessels.Weapons
{
    public interface IWeapon
    {
        int Range { get; set; }
        int CloseRange { get; set; }
        int Damage { get; set; }
    }
}
