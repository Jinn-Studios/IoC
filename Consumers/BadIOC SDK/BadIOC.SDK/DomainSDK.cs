using JinnDev.BadIOC.Models;

namespace JinnDev.BadIOC.SDK
{
    public class DomainSDK : IDomainSDK
    {
        public DomainSDK(string endpointConfiguration) { }

        // This SDK alone is fine.  But why do we use SDK's?  So that a dependent
        // can make a decoupled call, through an API, to some third party Domain
        // But why call through a Domain if we have a literal reference to
        // its implementation here?  Forget the API Call, that's Slow!!!!
        // And therefore... we have broken the whole purpose of an SDK.
        public ValueModel GetValue(int valueId)
            => null; // In reality, this would return the result of some API Call
    }
}