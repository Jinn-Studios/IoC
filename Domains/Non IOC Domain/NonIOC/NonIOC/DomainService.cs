using JinnDev.NonIOC.Models;

namespace JinnDev.NonIOC
{
    public class DomainService
    {
        private Data.DataRepository _repo;
        private BadIOC.SDK.IDomainSDK _badIocSdk;

        public DomainService(Data.DataRepository repo, BadIOC.SDK.IDomainSDK badIocSdk)
        {
            _repo = repo;
            _badIocSdk = badIocSdk;
        }

        public ValueModel GetValue(int valueId)
        {
            var result = _repo.GetValue(valueId).ConvertToModel();
            var otherValue = _badIocSdk.GetValue(valueId);
            result.Value += " - This came From the NonIOC DomainService!";
            return result;
        }

        public void SetValue(ValueModel value)
            => _repo.SetValue(value.ConvertToEntity());
    }
}