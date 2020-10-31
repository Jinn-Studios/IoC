using JinnDev.BadIOC.Data.Core;
using JinnDev.BadIOC.Data.Entities;

namespace JinnDev.BadIOC.UnitTests
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