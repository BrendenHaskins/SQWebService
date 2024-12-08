using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQWebService.Models.Vessels;
using System;

namespace SQWebService.UnitTests
{
    [TestClass]
    public class VesselCommonTests
    {
        [TestMethod]
        public void GenerateNames_VesselIsValid_ReturnsString()
        {
            var driver = new VesselCommon();
            var allValidVesselClassses = driver.namingLists.Keys;
            var allowedNames = driver.namingLists.Values;
            var names = new List<string>();

            foreach (string vesselClass in allValidVesselClassses)
            {
                names.Add(driver.GenerateName(vesselClass));
            }

            foreach(string randomName in names)
            {
                Assert.IsNotNull(randomName);
            }
        }
        [TestMethod]
        public void GenerateNames_VesselIsInvalid_ThrowsException()
        {
            var driver = new VesselCommon();
            Assert.ThrowsException<Exception>(() => driver.GenerateName("NonExistVesselClassName"));
        }
    }
}
