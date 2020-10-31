using JinnDev.SingularIOC.Data.Entities;

namespace JinnDev.SingularIOC.Data
{
    public class SingularRepo : Core.ISingularRepo
    {
        public SingularEntity GetValue(int valueId)
            => new SingularEntity { Id = valueId, Value = "Value with ID of " + valueId };

        public void SetValue(SingularEntity value)
        {
            throw new System.Exception("This should only be hit by domain code, but the current demo only shows if this is hit during Unit Tests, which is a no-no");
        }
    }
}