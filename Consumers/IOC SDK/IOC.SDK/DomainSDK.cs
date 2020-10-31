using JinnDev.IOC.Models;

namespace JinnDev.IOC.SDK
{
    public class DomainSDK : IDomainSDK
    {
        public DomainSDK(string endpointConfiguration) { }

        // Since a Consumer can retrieve the IOC Domain's Model here without
        // knowing about the IOC Domain's Implementation, this SDK is perfect.
        public ValueModel GetValue(int valueId)
            => null; // In reality, this would return the result of some API Call
    }
}