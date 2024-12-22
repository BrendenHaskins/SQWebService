using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQWebService.Models.Vessels;
using SQWebService.Models.Vessels.Weapons;
using SQWebService.Models.Vessels.Weapons.DefensiveWeapons;
using SQWebService.Models.Vessels.Weapons.OffensiveWeapons;
using System;

namespace SQWebService.UnitTests
{
    [TestClass]
    public class VesselCommonTests
    {
        [TestMethod]
        public void GenerateNames_VesselIsValid_ReturnsString()
        {

            var allValidVesselClassses = VesselCommon.namingLists.Keys;
            var allowedNames = VesselCommon.namingLists.Values;
            var names = new List<string>();

            foreach (string vesselClass in allValidVesselClassses)
            {
                names.Add(VesselCommon.GenerateName(vesselClass));
            }

            foreach(string randomName in names)
            {
                Assert.IsNotNull(randomName);
            }
        }
        [TestMethod]
        public void GenerateNames_VesselIsInvalid_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => VesselCommon.GenerateName("NonExistVesselClassName"));
        }
        [TestMethod]
        public void GenerateSeed_VesselIsValidWithNoWeapons_SeedGeneratedCopySeedEqualsOriginalSeed()
        {
            Vessel testVessel = new Vessel(001, "Screaming Eagle", 1, 3, 8, 12, 10);
            Vessel seededVessel = Vessel.GenerateVesselFromSeed(testVessel.Seed);

            Assert.IsNotNull(seededVessel);
            Assert.AreEqual(seededVessel.Seed, testVessel.Seed);
        }
        [TestMethod]
        public void GenerateSeed_VesselIsValidWithValidWeapons_SeedGeneratedCopySeedEqualsOriginalSeed()
        {
            var OffensiveWeapons = new List<IOffensiveWeapon>();
            var DefensiveWeapons = new List<IDefensiveWeapon>();

            OffensiveWeapons.Add( (IOffensiveWeapon) WeaponCommon.GenerateWeaponFromShorthand("S1"));
            DefensiveWeapons.Add((IDefensiveWeapon)WeaponCommon.GenerateWeaponFromShorthand("D1"));
            Vessel testVessel = new Vessel(001, "Screaming Eagle", 1, 3, 8, 12, 10, OffensiveWeapons, DefensiveWeapons);
            Vessel seededVessel = Vessel.GenerateVesselFromSeed(testVessel.Seed);

            Assert.IsNotNull(seededVessel);
            Assert.AreEqual(seededVessel.Seed, testVessel.Seed);
        }
        [TestMethod]
        public void Driver_Test_SeedGen()
        {
            FleetExport.Main();
            Assert.IsTrue(true);
        }
    }
}
