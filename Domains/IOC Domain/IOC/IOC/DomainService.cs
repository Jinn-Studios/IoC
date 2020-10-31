using JinnDev.IOC.Models;

namespace JinnDev.IOC
{
    public class DomainService : Core.IDomainService
    {
        private Data.Core.IDataRepository _repo;
        private SingularIOC.SDK.ISingularSDK _singularSDK;

        public DomainService(Data.Core.IDataRepository repo, SingularIOC.SDK.ISingularSDK singularSDK)
        {
            _repo = repo;
            _singularSDK = singularSDK;
        }

        public ValueModel GetValue(int valueId)
        {
            var result = _repo.GetValue(valueId).ConvertToModel();
            var otherResult = _singularSDK.GetValue(valueId);
            result.Value += " - This came From the IOC DomainService!";
            return result;
        }

        public void SetValue(ValueModel value)
            => _repo.SetValue(value.ConvertToEntity());
    }
}