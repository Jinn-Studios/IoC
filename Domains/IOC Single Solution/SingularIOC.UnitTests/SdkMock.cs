using JinnDev.IOC.Models;
using JinnDev.IOC.SDK;

namespace JinnDev.SingularIOC.UnitTests
{
    public class SdkMock : IDomainSDK
    {
        public ValueModel GetValue(int valueId)
        {
            return new ValueModel { Value = "Just a test" };
        }
    }
}