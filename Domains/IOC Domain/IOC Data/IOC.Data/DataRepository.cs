using JinnDev.IOC.Data.Entities;

namespace JinnDev.IOC.Data
{
    public class DataRepository : Core.IDataRepository
    {
        public ValueEntity GetValue(int valueId)
            => new ValueEntity { Id = valueId, Value = "Value with ID of " + valueId };

        public void SetValue(ValueEntity value)
        {
            throw new System.Exception("This should only be hit by domain code, but the current demo only shows if this is hit during Unit Tests, which is a no-no");
        }
    }
}