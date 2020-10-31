using JinnDev.BadIOC.Models;

namespace JinnDev.BadIOC.Core
{
    // This interface being in the same NuGet as the Service means anybody who wants to consume
    // the interface must also know about the implementation
    // There may be another talk later about "default implementation", but this term...
    // I do not think it means what you think it means.
    public interface IDomainService
    {
        ValueModel GetValue(int valueId);
        void SetValue(ValueModel value);
    }
}