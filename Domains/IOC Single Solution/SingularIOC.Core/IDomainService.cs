using JinnDev.SingularIOC.Models;

namespace JinnDev.SingularIOC.Core
{
    public interface ISingularService
    {
        SingularModel GetValue(int valueId);
        void SetValue(SingularModel value);
    }
}