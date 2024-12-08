using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQWebService.Models.Vessels.VesselCommon;
using System;

namespace SQWebService.UnitTests
{
    [TestClass]
    public class VesselCommonTests
    {
        [TestMethod]
        public void GenerateValidNames_VesselIsValid_ReturnsString()
        {
            var output = VesselCommon.GenerateName();
        }
    }
}
