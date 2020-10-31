using JinnDev.SingularIOC.Models;

namespace JinnDev.SingularIOC.SDK
{
    public class SingularSDK : ISingularSDK
    {
        public SingularSDK(string endpointConfiguration) { }

        // Since a Consumer can retrieve the IOC Domain's Model here without
        // knowing about the IOC Domain's Implementation, this SDK is perfect.
        public SingularModel GetValue(int valueId)
            => null; // In reality, this would return the result of some API Call
    }
}