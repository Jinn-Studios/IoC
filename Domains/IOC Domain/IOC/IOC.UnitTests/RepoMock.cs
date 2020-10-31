using JinnDev.IOC.Data.Core;
using JinnDev.IOC.Data.Entities;

namespace JinnDev.IOC.UnitTests
{
    public class RepoMock : IDataRepository
    {
        public ValueEntity GetValue(int valueId)
            => new ValueEntity { Id = valueId, Value = "Value with ID of " + valueId };

        public void SetValue(ValueEntity value)
        {
            // Don't do anything, cuz it's mocked out! :) 
        }
    }
}