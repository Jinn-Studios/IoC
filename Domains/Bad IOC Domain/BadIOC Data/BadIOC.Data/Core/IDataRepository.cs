using JinnDev.BadIOC.Data.Entities;

namespace JinnDev.BadIOC.Data.Core
{
    public interface IDataRepository
    {
        // This interface being in the same NuGet as the Service means anybody who wants to consume
        // the interface must also know about the implementation
        // There may be another talk later about "default implementation", but this term...
        // I do not think it means what you think it means.
        ValueEntity GetValue(int valueId);
        void SetValue(ValueEntity value);
    }
}