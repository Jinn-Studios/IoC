using JinnDev.BadIOC.Models;

namespace JinnDev.BadIOC.SDK
{
    public interface IDomainSDK
    {
        ValueModel GetValue(int valueId);
    }
}