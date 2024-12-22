namespace SQWebService.Models.Vessels.Weapons
{

    /// <summary> all weapon common attributes </summary>
    /// <param name="Name"> name of the weapon (e.g 375 MM Cannon) </param>
    /// <param name="Shorthand"> shorthand representation (e.g L1) </param>
    /// <param name="Size"> size of the weapon (e.g Large) </param>
    /// <param name="CloseRange"> distance considered close range (e.g 10) </param>
    /// <param name="Damage"> damage of the weapon (e.g 10) </param>
    /// <param name="HitType"> calculation for damage in game (e.g Roll Dice, Hits on Even 2, 4, 6) </param>


    public interface IWeapon
    {
        public string Name { get; }
        public string Shorthand { get; }
        public char Size { get; }
        public int Range { get; }
    }
}
