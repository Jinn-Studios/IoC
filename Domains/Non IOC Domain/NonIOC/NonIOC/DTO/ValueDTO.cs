using JinnDev.NonIOC.Models;

namespace JinnDev.NonIOC
{
    public static class ValueDTO
    {
        public static ValueModel ConvertToModel(this Data.Entities.ValueEntity input)
        {
            return new ValueModel
            {
                Id = input.Id,
                Value = input.Value
            };
        }

        public static Data.Entities.ValueEntity ConvertToEntity(this ValueModel input)
        {
            return new Data.Entities.ValueEntity
            {
                Id = input.Id,
                Value = input.Value
            };
        }
    }
}