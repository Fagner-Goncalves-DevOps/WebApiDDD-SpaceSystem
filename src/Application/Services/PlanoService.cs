 using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services
{
    public class PlanoService : IPlanoService
    {
        private readonly IPlanoRepository _planoRepository;
        private readonly IMapper _mapper;

        public PlanoService(IPlanoRepository planoRepository,
                             IMapper mapper) 
        {
            _planoRepository = planoRepository;
            _mapper = mapper;
        }

        //metodos genericos padrão de visualização
        public async Task<IEnumerable<PlanoDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<PlanoDto>>(await _planoRepository.ObterTodos()); //usando genericos
        }
        public async Task<PlanoDto> ObterPorId(Guid id)
        {
            return _mapper.Map<PlanoDto>(await _planoRepository.ObterPorId(id));

        }

        //metodos genericos padrão de alteração
        public async Task Add(PlanoDto planoDto)
        {
            await _planoRepository.Adicionar(_mapper.Map<PlanoDto, PlanoDescricao>(planoDto));
        }
        public async Task Update(PlanoDto planoDto)
        {
          await _planoRepository.Atualizar( _mapper.Map<PlanoDto, PlanoDescricao>(planoDto));
        }
        public async Task Remove(Guid id)
        {
            await _planoRepository.Remover(id);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}




//return await _pessoaRepository.Adicionar(_mapper.Map<PessoaDto, Pessoa>(pessoaDto));

//  await _tabTelecomConsolidadoRepository.Adicionar(_mapper.Map<TabTelecomConsolidadoDto, TabTelecomConsolidado>(tabTelecomConsolidadoDto));
