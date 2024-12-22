using SQWebService.Models.Vessels;
using SQWebService.Models.Vessels.Weapons;
using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;
using System;

public class FleetExport
{
    public static void Main()
    {
        var OffensiveWeapons = new List<IOffensiveWeapon>();
        var DefensiveWeapons = new List<IDefensiveWeapon>();
        OffensiveWeapons.Add((IOffensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand("S1"));
        DefensiveWeapons.Add((IDefensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand("D1"));
        DefensiveWeapons.Add((IDefensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand("D2"));



        Vessel testVessel = new Vessel(001,VesselCommon.GenerateName("Corvette"),1,2,12,6,12,OffensiveWeapons,DefensiveWeapons);
        OutputVesselSeedToConsole(testVessel);
    } 
    public static void OutputVesselSeedToConsole(Vessel Vessel)
    {
        Console.WriteLine(VesselCommon.GenerateSeed(Vessel));
    }
}