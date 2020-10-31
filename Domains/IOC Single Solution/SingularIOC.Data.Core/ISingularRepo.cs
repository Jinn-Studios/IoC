using JinnDev.SingularIOC.Data.Entities;

namespace JinnDev.SingularIOC.Data.Core
{
    public interface ISingularRepo
    {
        SingularEntity GetValue(int valueId);
        void SetValue(SingularEntity value);
    }
}