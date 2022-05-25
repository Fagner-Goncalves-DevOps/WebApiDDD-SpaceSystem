using Application.Dtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
            CreateMap<Pessoa, PessoaEnderecoDto>().ReverseMap();
            CreateMap<Pessoa, PessoaContratoEnderecoDto>().ReverseMap();

            CreateMap<Contrato, ContratoDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();

            CreateMap<Parcela, ParcelaDto>().ReverseMap();
            CreateMap<PlanoDescricao, PlanoDto>().ReverseMap();

            // .ForMember(x => x.Password, y => y.MapFrom(m => UtilsService.EncryptPassword(m.Password)));
        }
    }
}
