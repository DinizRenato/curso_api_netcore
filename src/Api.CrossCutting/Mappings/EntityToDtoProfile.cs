using Api.Domain.dtos.Cep;
using Api.Domain.dtos.municipio;
using Api.Domain.dtos.uf;
using Api.Domain.dtos.User;
using Api.Domain.Dtos.Cep;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {

            CreateMap<UserDto, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
                .ReverseMap();

            CreateMap<UfDto, UfEntity>()
                .ReverseMap();

            CreateMap<MunicipioDto, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDtoCompleto, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>()
                .ReverseMap();

            CreateMap<CepDto, CepEntity>()
                .ReverseMap();

            CreateMap<CepDtoCreateResult, CepEntity>()
                .ReverseMap();

            CreateMap<CepDtoUpdateResult, CepEntity>()
                .ReverseMap();

        }
    }
}
