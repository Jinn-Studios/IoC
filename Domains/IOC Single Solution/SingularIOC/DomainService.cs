using JinnDev.SingularIOC.Models;

namespace JinnDev.SingularIOC
{
    public class SingularService : Core.ISingularService
    {
        private Data.Core.ISingularRepo _repo;
        private IOC.SDK.IDomainSDK _domainSDK;

        public SingularService(Data.Core.ISingularRepo repo, IOC.SDK.IDomainSDK domainSDK)
        {
            _repo = repo;
            _domainSDK = domainSDK;
        }

        public SingularModel GetValue(int valueId)
        {
            var result = _repo.GetValue(valueId).ConvertToModel();
            var otherResult = _domainSDK.GetValue(valueId);
            result.Value += " - This came From the IOC DomainService!";
            return result;
        }

        public void SetValue(SingularModel value)
            => _repo.SetValue(value.ConvertToEntity());
    }
}