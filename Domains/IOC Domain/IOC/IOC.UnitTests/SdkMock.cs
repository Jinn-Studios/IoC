using JinnDev.SingularIOC.Models;
using JinnDev.SingularIOC.SDK;

namespace JinnDev.IOC.UnitTests
{
    public class SdkMock : ISingularSDK
    {
        public SingularModel GetValue(int valueId)
        {
            return new SingularModel { Value = "Just a test" };
        }
    }
}