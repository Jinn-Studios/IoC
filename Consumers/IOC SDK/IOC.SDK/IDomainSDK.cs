using JinnDev.IOC.Models;

namespace JinnDev.IOC.SDK
{
    public interface IDomainSDK
    {
        ValueModel GetValue(int valueId);
    }
}