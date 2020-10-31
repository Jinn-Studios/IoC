using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JinnDev.IOC.UnitTests
{
    [TestClass]
    public class DomainServiceTests
    {
        [TestMethod]
        public void GetValue_ProperID_ReturnsDomainValue()
        {
            var id = 1;
            var expected = "Value with ID of " + id + " - This came From the IOC DomainService!";
            var sut = new DomainService(new RepoMock(), new SdkMock());
            var actual = sut.GetValue(id);

            Assert.AreEqual(expected, actual.Value);
        }

        [TestMethod]
        public void SetValue_ProperID_DoesntExplode()
        {
            var sut = new DomainService(new RepoMock(), new SdkMock());
            sut.SetValue(new Models.ValueModel { Value = "Test Value" });
        }
    }
}