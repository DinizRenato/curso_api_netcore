using Api.Domain.dtos.Cep;
using Api.Domain.dtos.municipio;
using Api.Domain.dtos.uf;
using Api.Domain.dtos.User;
using Api.Domain.Dtos.Cep;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>()
            .ReverseMap();

            CreateMap<UserModel, UserDtoCreate>()
            .ReverseMap();

            CreateMap<UserModel, UserDtoUpdate>()
            .ReverseMap();
            #endregion

            #region Uf
            CreateMap<UfModel, UfDto>()
            .ReverseMap();
            #endregion

            #region Municipio
            CreateMap<MunicipioModel, MunicipioDto>()
            .ReverseMap();

            CreateMap<MunicipioModel, MunicipioDtoCreate>()
            .ReverseMap();

            CreateMap<MunicipioModel, MunicipioDtoUpdate>()
            .ReverseMap();
            #endregion

            #region CEP
            CreateMap<CepModel, CepDto>()
            .ReverseMap();
            CreateMap<CepModel, CepDtoCreate>()
            .ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>()
            .ReverseMap();
            #endregion

        }
    }
}
