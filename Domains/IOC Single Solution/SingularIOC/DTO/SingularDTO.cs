using JinnDev.SingularIOC.Models;

namespace JinnDev.SingularIOC
{
    public static class SingularDTO
    {
        public static SingularModel ConvertToModel(this Data.Entities.SingularEntity input)
        {
            return new SingularModel
            {
                Id = input.Id,
                Value = input.Value
            };
        }

        public static Data.Entities.SingularEntity ConvertToEntity(this SingularModel input)
        {
            return new Data.Entities.SingularEntity
            {
                Id = input.Id,
                Value = input.Value
            };
        }
    }
}