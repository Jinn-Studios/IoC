using JinnDev.SingularIOC.Models;

namespace JinnDev.SingularIOC.SDK
{
    public interface ISingularSDK
    {
        SingularModel GetValue(int valueId);
    }
}