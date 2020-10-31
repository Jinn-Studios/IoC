using JinnDev.IOC.Data.Entities;

namespace JinnDev.IOC.Data.Core
{
    public interface IDataRepository
    {
        ValueEntity GetValue(int valueId);
        void SetValue(ValueEntity value);
    }
}