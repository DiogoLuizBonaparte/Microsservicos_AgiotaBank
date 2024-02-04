using AutoMapper;
using BancoStandard.EmprestimosAPI.Data.ValueObjects;
using BancoStandard.EmprestimosAPI.Model;

namespace BancoStandard.EmprestimosAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            { config.CreateMap<ContractVO, Contract>();
              config.CreateMap<Contract, ContractVO>();
            });
            return mappingConfig;
        }
    }
}
