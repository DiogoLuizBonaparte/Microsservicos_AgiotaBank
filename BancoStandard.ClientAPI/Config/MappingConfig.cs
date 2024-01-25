using AutoMapper;
using BancoStandard.CadastroAPI.Data.ValueObjects;
using BancoStandard.ClientAPI.Model;

namespace BancoStandard.CadastroAPI.Config
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ClienteVO, Cliente>();
                config.CreateMap<Cliente, ClienteVO>();
            });
            return mappingConfig;
        }
    }
}
