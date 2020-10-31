using JinnDev.BadIOC.Core;
using JinnDev.BadIOC.Models;

namespace JinnDev.BadIOC
{
    public class DomainService : IDomainService
    {
        private Data.Core.IDataRepository _repo;

        public DomainService(Data.Core.IDataRepository repo)
        {
            _repo = repo;
        }

        public ValueModel GetValue(int valueId)
        {
            var result = _repo.GetValue(valueId).ConvertToModel();
            result.Value += " - This came From the BadIOC DomainService!";
            return result;
        }

        public void SetValue(ValueModel value)
            => _repo.SetValue(value.ConvertToEntity());
    }
}