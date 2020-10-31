using JinnDev.IOC.Models;

namespace JinnDev.IOC.Core
{
    public interface IDomainService
    {
        ValueModel GetValue(int valueId);
        void SetValue(ValueModel value);
    }
}