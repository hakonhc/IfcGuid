using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    using System.Diagnostics;

    using IfcGuid;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var id = Guid.NewGuid();
            var ifcGuid = IfcGuid.ToIfcGuid(id);
            var back = IfcGuid.FromIfcGuid(ifcGuid);
            Assert.AreEqual(back, id);
            Debug.WriteLine(ifcGuid, id.ToString());
        }

        [TestMethod]
        public void IfcGuidTestCases()
        {
            string ifcguid = "01psB8wRl0Y00000000005";
            Assert.AreEqual(ifcguid, IfcGuid.ToIfcGuid(IfcGuid.FromIfcGuid(ifcguid)));
        }

        [TestMethod]
        public void GuidTestCases()
        {
            string guid = "01cf62c8-e9bc-bf88-0000-000000000005";
            var res = IfcGuid.FromIfcGuid(IfcGuid.ToIfcGuid(new Guid(guid)));
            Assert.AreEqual(guid, res.ToString());
        }

        [TestMethod]
        public void TestCompare()
        {
            string guid = "01cf62c8-e9bc-bf88-0000-000000000005";
            string ifcguid = "01psB8wRo$Y00000000005";
            var convertedGuid = IfcGuid.ToIfcGuid(new Guid(guid));
            Assert.AreEqual(convertedGuid, ifcguid);
        }
    }
}
