using JinnDev.SingularIOC.Data.Core;
using JinnDev.SingularIOC.Data.Entities;

namespace JinnDev.SingularIOC.UnitTests
{
    public class RepoMock : ISingularRepo
    {
        public SingularEntity GetValue(int valueId)
            => new SingularEntity { Id = valueId, Value = "Value with ID of " + valueId };

        public void SetValue(SingularEntity value)
        {
            // Don't do anything, cuz it's mocked out! :) 
        }
    }
}